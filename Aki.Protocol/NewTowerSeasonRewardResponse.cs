using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4A RID: 2890
	[NetMessage(EMessageId.NewTowerSeasonRewardResponse)]
	public sealed class NewTowerSeasonRewardResponse : IMessage<NewTowerSeasonRewardResponse>, IMessage, IEquatable<NewTowerSeasonRewardResponse>, IDeepCloneable<NewTowerSeasonRewardResponse>, IBufferMessage
	{
		// Token: 0x0600FAAF RID: 64175 RVA: 0x00248BBD File Offset: 0x00246DBD
		[NullableContext(1)]
		public static NewTowerSeasonRewardResponse Create()
		{
			return new NewTowerSeasonRewardResponse();
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600FAB0 RID: 64176 RVA: 0x00248BC4 File Offset: 0x00246DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600FAB1 RID: 64177 RVA: 0x00248BC7 File Offset: 0x00246DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600FAB2 RID: 64178 RVA: 0x00248BCE File Offset: 0x00246DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardResponse()
		{
		}

		// Token: 0x0600FAB3 RID: 64179 RVA: 0x00248BD6 File Offset: 0x00246DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardResponse(NewTowerSeasonRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAB4 RID: 64180 RVA: 0x00248BFB File Offset: 0x00246DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardResponse Clone()
		{
			return new NewTowerSeasonRewardResponse(this);
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600FAB5 RID: 64181 RVA: 0x00248C03 File Offset: 0x00246E03
		// (set) Token: 0x0600FAB6 RID: 64182 RVA: 0x00248C0B File Offset: 0x00246E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600FAB7 RID: 64183 RVA: 0x00248C14 File Offset: 0x00246E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonRewardResponse);
		}

		// Token: 0x0600FAB8 RID: 64184 RVA: 0x00248C22 File Offset: 0x00246E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FAB9 RID: 64185 RVA: 0x00248C50 File Offset: 0x00246E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FABA RID: 64186 RVA: 0x00248C95 File Offset: 0x00246E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FABB RID: 64187 RVA: 0x00248CA2 File Offset: 0x00246EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FABC RID: 64188 RVA: 0x00248CAB File Offset: 0x00246EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FABD RID: 64189 RVA: 0x00248CE0 File Offset: 0x00246EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FABE RID: 64190 RVA: 0x00248D1E File Offset: 0x00246F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FABF RID: 64191 RVA: 0x00248D4F File Offset: 0x00246F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FAC0 RID: 64192 RVA: 0x00248D58 File Offset: 0x00246F58
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006453 RID: 25683
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006454 RID: 25684
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006455 RID: 25685
		private ErrorCode errorCode_;
	}
}
