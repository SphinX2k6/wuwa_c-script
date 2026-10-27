using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D32 RID: 3378
	[NetMessage(EMessageId.PhotographPush)]
	public sealed class PhotographPush : IMessage<PhotographPush>, IMessage, IEquatable<PhotographPush>, IDeepCloneable<PhotographPush>, IBufferMessage
	{
		// Token: 0x060123D0 RID: 74704 RVA: 0x002A9D58 File Offset: 0x002A7F58
		[NullableContext(1)]
		public static PhotographPush Create()
		{
			return new PhotographPush();
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x060123D1 RID: 74705 RVA: 0x002A9D5F File Offset: 0x002A7F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x060123D2 RID: 74706 RVA: 0x002A9D62 File Offset: 0x002A7F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotographPush.Descriptor;
			}
		}

		// Token: 0x060123D3 RID: 74707 RVA: 0x002A9D69 File Offset: 0x002A7F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotographPush()
		{
		}

		// Token: 0x060123D4 RID: 74708 RVA: 0x002A9D71 File Offset: 0x002A7F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotographPush(PhotographPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123D5 RID: 74709 RVA: 0x002A9D8A File Offset: 0x002A7F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotographPush Clone()
		{
			return new PhotographPush(this);
		}

		// Token: 0x060123D6 RID: 74710 RVA: 0x002A9D92 File Offset: 0x002A7F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotographPush);
		}

		// Token: 0x060123D7 RID: 74711 RVA: 0x002A9DA0 File Offset: 0x002A7FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotographPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060123D8 RID: 74712 RVA: 0x002A9DC0 File Offset: 0x002A7FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060123D9 RID: 74713 RVA: 0x002A9DE6 File Offset: 0x002A7FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123DA RID: 74714 RVA: 0x002A9DF3 File Offset: 0x002A7FF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123DB RID: 74715 RVA: 0x002A9DFC File Offset: 0x002A7FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060123DC RID: 74716 RVA: 0x002A9E14 File Offset: 0x002A8014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060123DD RID: 74717 RVA: 0x002A9E3A File Offset: 0x002A803A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotographPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060123DE RID: 74718 RVA: 0x002A9E57 File Offset: 0x002A8057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123DF RID: 74719 RVA: 0x002A9E60 File Offset: 0x002A8060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040071DB RID: 29147
		private UnknownFieldSet _unknownFields;
	}
}
