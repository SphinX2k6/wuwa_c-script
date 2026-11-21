using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B09 RID: 2825
	[NetMessage(EMessageId.NewLinkBurstPush)]
	public sealed class NewLinkBurstPush : IMessage<NewLinkBurstPush>, IMessage, IEquatable<NewLinkBurstPush>, IDeepCloneable<NewLinkBurstPush>, IBufferMessage
	{
		// Token: 0x0600F5A8 RID: 62888 RVA: 0x0023D82A File Offset: 0x0023BA2A
		[NullableContext(1)]
		public static NewLinkBurstPush Create()
		{
			return new NewLinkBurstPush();
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600F5A9 RID: 62889 RVA: 0x0023D831 File Offset: 0x0023BA31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600F5AA RID: 62890 RVA: 0x0023D834 File Offset: 0x0023BA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewLinkBurstPush.Descriptor;
			}
		}

		// Token: 0x0600F5AB RID: 62891 RVA: 0x0023D83B File Offset: 0x0023BA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkBurstPush()
		{
		}

		// Token: 0x0600F5AC RID: 62892 RVA: 0x0023D843 File Offset: 0x0023BA43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkBurstPush(NewLinkBurstPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5AD RID: 62893 RVA: 0x0023D85C File Offset: 0x0023BA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewLinkBurstPush Clone()
		{
			return new NewLinkBurstPush(this);
		}

		// Token: 0x0600F5AE RID: 62894 RVA: 0x0023D864 File Offset: 0x0023BA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewLinkBurstPush);
		}

		// Token: 0x0600F5AF RID: 62895 RVA: 0x0023D872 File Offset: 0x0023BA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewLinkBurstPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F5B0 RID: 62896 RVA: 0x0023D890 File Offset: 0x0023BA90
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

		// Token: 0x0600F5B1 RID: 62897 RVA: 0x0023D8B6 File Offset: 0x0023BAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5B2 RID: 62898 RVA: 0x0023D8C3 File Offset: 0x0023BAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5B3 RID: 62899 RVA: 0x0023D8CC File Offset: 0x0023BACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F5B4 RID: 62900 RVA: 0x0023D8E4 File Offset: 0x0023BAE4
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

		// Token: 0x0600F5B5 RID: 62901 RVA: 0x0023D90A File Offset: 0x0023BB0A
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

		// Token: 0x0600F5B6 RID: 62902 RVA: 0x0023D927 File Offset: 0x0023BB27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5B7 RID: 62903 RVA: 0x0023D930 File Offset: 0x0023BB30
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

		// Token: 0x04006315 RID: 25365
		private UnknownFieldSet _unknownFields;
	}
}
