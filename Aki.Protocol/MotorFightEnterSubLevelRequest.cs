using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3F RID: 2623
	[NetMessage(EMessageId.MotorFightEnterSubLevelRequest)]
	public sealed class MotorFightEnterSubLevelRequest : IMessage<MotorFightEnterSubLevelRequest>, IMessage, IEquatable<MotorFightEnterSubLevelRequest>, IDeepCloneable<MotorFightEnterSubLevelRequest>, IBufferMessage
	{
		// Token: 0x0600E507 RID: 58631 RVA: 0x00217C8E File Offset: 0x00215E8E
		[NullableContext(1)]
		public static MotorFightEnterSubLevelRequest Create()
		{
			return new MotorFightEnterSubLevelRequest();
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x0600E508 RID: 58632 RVA: 0x00217C95 File Offset: 0x00215E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x0600E509 RID: 58633 RVA: 0x00217C98 File Offset: 0x00215E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightEnterSubLevelRequest.Descriptor;
			}
		}

		// Token: 0x0600E50A RID: 58634 RVA: 0x00217C9F File Offset: 0x00215E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelRequest()
		{
		}

		// Token: 0x0600E50B RID: 58635 RVA: 0x00217CA7 File Offset: 0x00215EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelRequest(MotorFightEnterSubLevelRequest other) : this()
		{
			this.subLevelIndex_ = other.subLevelIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E50C RID: 58636 RVA: 0x00217CCC File Offset: 0x00215ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightEnterSubLevelRequest Clone()
		{
			return new MotorFightEnterSubLevelRequest(this);
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x0600E50D RID: 58637 RVA: 0x00217CD4 File Offset: 0x00215ED4
		// (set) Token: 0x0600E50E RID: 58638 RVA: 0x00217CDC File Offset: 0x00215EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelIndex
		{
			get
			{
				return this.subLevelIndex_;
			}
			set
			{
				this.subLevelIndex_ = value;
			}
		}

		// Token: 0x0600E50F RID: 58639 RVA: 0x00217CE5 File Offset: 0x00215EE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightEnterSubLevelRequest);
		}

		// Token: 0x0600E510 RID: 58640 RVA: 0x00217CF3 File Offset: 0x00215EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightEnterSubLevelRequest other)
		{
			return other != null && (other == this || (this.SubLevelIndex == other.SubLevelIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E511 RID: 58641 RVA: 0x00217D24 File Offset: 0x00215F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelIndex != 0)
			{
				num ^= this.SubLevelIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E512 RID: 58642 RVA: 0x00217D63 File Offset: 0x00215F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E513 RID: 58643 RVA: 0x00217D70 File Offset: 0x00215F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E514 RID: 58644 RVA: 0x00217D79 File Offset: 0x00215F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SubLevelIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E515 RID: 58645 RVA: 0x00217DAC File Offset: 0x00215FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E516 RID: 58646 RVA: 0x00217DEA File Offset: 0x00215FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightEnterSubLevelRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelIndex != 0)
			{
				this.SubLevelIndex = other.SubLevelIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E517 RID: 58647 RVA: 0x00217E1B File Offset: 0x0021601B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E518 RID: 58648 RVA: 0x00217E24 File Offset: 0x00216024
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SubLevelIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005DA5 RID: 23973
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DA6 RID: 23974
		public const int SubLevelIndexFieldNumber = 6;

		// Token: 0x04005DA7 RID: 23975
		private int subLevelIndex_;
	}
}
