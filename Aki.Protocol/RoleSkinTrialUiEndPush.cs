using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C3 RID: 4291
	[NetMessage(EMessageId.RoleSkinTrialUiEndPush)]
	public sealed class RoleSkinTrialUiEndPush : IMessage<RoleSkinTrialUiEndPush>, IMessage, IEquatable<RoleSkinTrialUiEndPush>, IDeepCloneable<RoleSkinTrialUiEndPush>, IBufferMessage
	{
		// Token: 0x06016E6B RID: 93803 RVA: 0x0035351F File Offset: 0x0035171F
		[NullableContext(1)]
		public static RoleSkinTrialUiEndPush Create()
		{
			return new RoleSkinTrialUiEndPush();
		}

		// Token: 0x17004CB7 RID: 19639
		// (get) Token: 0x06016E6C RID: 93804 RVA: 0x00353526 File Offset: 0x00351726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CB8 RID: 19640
		// (get) Token: 0x06016E6D RID: 93805 RVA: 0x00353529 File Offset: 0x00351729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinTrialUiEndPush.Descriptor;
			}
		}

		// Token: 0x06016E6E RID: 93806 RVA: 0x00353530 File Offset: 0x00351730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialUiEndPush()
		{
		}

		// Token: 0x06016E6F RID: 93807 RVA: 0x00353538 File Offset: 0x00351738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialUiEndPush(RoleSkinTrialUiEndPush other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E70 RID: 93808 RVA: 0x00353551 File Offset: 0x00351751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinTrialUiEndPush Clone()
		{
			return new RoleSkinTrialUiEndPush(this);
		}

		// Token: 0x06016E71 RID: 93809 RVA: 0x00353559 File Offset: 0x00351759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinTrialUiEndPush);
		}

		// Token: 0x06016E72 RID: 93810 RVA: 0x00353567 File Offset: 0x00351767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinTrialUiEndPush other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016E73 RID: 93811 RVA: 0x00353588 File Offset: 0x00351788
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

		// Token: 0x06016E74 RID: 93812 RVA: 0x003535AE File Offset: 0x003517AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E75 RID: 93813 RVA: 0x003535BB File Offset: 0x003517BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E76 RID: 93814 RVA: 0x003535C4 File Offset: 0x003517C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E77 RID: 93815 RVA: 0x003535DC File Offset: 0x003517DC
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

		// Token: 0x06016E78 RID: 93816 RVA: 0x00353602 File Offset: 0x00351802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinTrialUiEndPush other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E79 RID: 93817 RVA: 0x0035361F File Offset: 0x0035181F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E7A RID: 93818 RVA: 0x00353628 File Offset: 0x00351828
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

		// Token: 0x04008883 RID: 34947
		private UnknownFieldSet _unknownFields;
	}
}
