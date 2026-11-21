using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D6 RID: 1238
	[NetMessage(EMessageId.ExitViewDirectionPush)]
	public sealed class ExitViewDirectionPush : IMessage<ExitViewDirectionPush>, IMessage, IEquatable<ExitViewDirectionPush>, IDeepCloneable<ExitViewDirectionPush>, IBufferMessage
	{
		// Token: 0x060075B9 RID: 30137 RVA: 0x0012020E File Offset: 0x0011E40E
		[NullableContext(1)]
		public static ExitViewDirectionPush Create()
		{
			return new ExitViewDirectionPush();
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x060075BA RID: 30138 RVA: 0x00120215 File Offset: 0x0011E415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x060075BB RID: 30139 RVA: 0x00120218 File Offset: 0x0011E418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExitViewDirectionPush.Descriptor;
			}
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x0012021F File Offset: 0x0011E41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionPush()
		{
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x00120227 File Offset: 0x0011E427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionPush(ExitViewDirectionPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00120240 File Offset: 0x0011E440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExitViewDirectionPush Clone()
		{
			return new ExitViewDirectionPush(this);
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x00120248 File Offset: 0x0011E448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExitViewDirectionPush);
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x00120256 File Offset: 0x0011E456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExitViewDirectionPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00120274 File Offset: 0x0011E474
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

		// Token: 0x060075C2 RID: 30146 RVA: 0x0012029A File Offset: 0x0011E49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x001202A7 File Offset: 0x0011E4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x001202B0 File Offset: 0x0011E4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x001202C8 File Offset: 0x0011E4C8
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

		// Token: 0x060075C6 RID: 30150 RVA: 0x001202EE File Offset: 0x0011E4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExitViewDirectionPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x0012030B File Offset: 0x0011E50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00120314 File Offset: 0x0011E514
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

		// Token: 0x04003E14 RID: 15892
		private UnknownFieldSet _unknownFields;
	}
}
