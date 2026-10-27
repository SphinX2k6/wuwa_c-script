using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1A RID: 2842
	[NetMessage(EMessageId.NewLinkBurstPush)]
	public sealed class NewLinkBurstPush : IMessage<NewLinkBurstPush>, IMessage, IEquatable<NewLinkBurstPush>, IDeepCloneable<NewLinkBurstPush>, IBufferMessage
	{
		// Token: 0x0600F6C2 RID: 63170 RVA: 0x0023FA3E File Offset: 0x0023DC3E
		[NullableContext(1)]
		public static NewLinkBurstPush Create()
		{
			return new NewLinkBurstPush();
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600F6C3 RID: 63171 RVA: 0x0023FA45 File Offset: 0x0023DC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600F6C4 RID: 63172 RVA: 0x0023FA48 File Offset: 0x0023DC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewLinkBurstPush.Descriptor;
			}
		}

		// Token: 0x0600F6C5 RID: 63173 RVA: 0x0023FA4F File Offset: 0x0023DC4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkBurstPush()
		{
		}

		// Token: 0x0600F6C6 RID: 63174 RVA: 0x0023FA57 File Offset: 0x0023DC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkBurstPush(NewLinkBurstPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F6C7 RID: 63175 RVA: 0x0023FA70 File Offset: 0x0023DC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkBurstPush Clone()
		{
			return new NewLinkBurstPush(this);
		}

		// Token: 0x0600F6C8 RID: 63176 RVA: 0x0023FA78 File Offset: 0x0023DC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewLinkBurstPush);
		}

		// Token: 0x0600F6C9 RID: 63177 RVA: 0x0023FA86 File Offset: 0x0023DC86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewLinkBurstPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F6CA RID: 63178 RVA: 0x0023FAA4 File Offset: 0x0023DCA4
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

		// Token: 0x0600F6CB RID: 63179 RVA: 0x0023FACA File Offset: 0x0023DCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F6CC RID: 63180 RVA: 0x0023FAD7 File Offset: 0x0023DCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F6CD RID: 63181 RVA: 0x0023FAE0 File Offset: 0x0023DCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F6CE RID: 63182 RVA: 0x0023FAF8 File Offset: 0x0023DCF8
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

		// Token: 0x0600F6CF RID: 63183 RVA: 0x0023FB1E File Offset: 0x0023DD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewLinkBurstPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F6D0 RID: 63184 RVA: 0x0023FB3B File Offset: 0x0023DD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F6D1 RID: 63185 RVA: 0x0023FB44 File Offset: 0x0023DD44
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

		// Token: 0x0400630C RID: 25356
		private UnknownFieldSet _unknownFields;
	}
}
