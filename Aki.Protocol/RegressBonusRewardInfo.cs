using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECB RID: 3787
	public sealed class RegressBonusRewardInfo : IMessage<RegressBonusRewardInfo>, IMessage, IEquatable<RegressBonusRewardInfo>, IDeepCloneable<RegressBonusRewardInfo>, IBufferMessage
	{
		// Token: 0x0601453B RID: 83259 RVA: 0x002F4BBC File Offset: 0x002F2DBC
		[NullableContext(1)]
		public static RegressBonusRewardInfo Create()
		{
			return new RegressBonusRewardInfo();
		}

		// Token: 0x17004398 RID: 17304
		// (get) Token: 0x0601453C RID: 83260 RVA: 0x002F4BC3 File Offset: 0x002F2DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RegressBonusRewardInfo> Parser
		{
			get
			{
				return RegressBonusRewardInfo._parser;
			}
		}

		// Token: 0x17004399 RID: 17305
		// (get) Token: 0x0601453D RID: 83261 RVA: 0x002F4BCA File Offset: 0x002F2DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700439A RID: 17306
		// (get) Token: 0x0601453E RID: 83262 RVA: 0x002F4BCD File Offset: 0x002F2DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegressBonusRewardInfo.Descriptor;
			}
		}

		// Token: 0x0601453F RID: 83263 RVA: 0x002F4BD4 File Offset: 0x002F2DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRewardInfo()
		{
		}

		// Token: 0x06014540 RID: 83264 RVA: 0x002F4BDC File Offset: 0x002F2DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRewardInfo(RegressBonusRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014541 RID: 83265 RVA: 0x002F4C0D File Offset: 0x002F2E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRewardInfo Clone()
		{
			return new RegressBonusRewardInfo(this);
		}

		// Token: 0x1700439B RID: 17307
		// (get) Token: 0x06014542 RID: 83266 RVA: 0x002F4C15 File Offset: 0x002F2E15
		// (set) Token: 0x06014543 RID: 83267 RVA: 0x002F4C1D File Offset: 0x002F2E1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700439C RID: 17308
		// (get) Token: 0x06014544 RID: 83268 RVA: 0x002F4C26 File Offset: 0x002F2E26
		// (set) Token: 0x06014545 RID: 83269 RVA: 0x002F4C2E File Offset: 0x002F2E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegressBonusRewardType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x06014546 RID: 83270 RVA: 0x002F4C37 File Offset: 0x002F2E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegressBonusRewardInfo);
		}

		// Token: 0x06014547 RID: 83271 RVA: 0x002F4C45 File Offset: 0x002F2E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegressBonusRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014548 RID: 83272 RVA: 0x002F4C84 File Offset: 0x002F2E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != RegressBonusRewardType.Free)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014549 RID: 83273 RVA: 0x002F4CE2 File Offset: 0x002F2EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601454A RID: 83274 RVA: 0x002F4CEF File Offset: 0x002F2EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601454B RID: 83275 RVA: 0x002F4CF8 File Offset: 0x002F2EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != RegressBonusRewardType.Free)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601454C RID: 83276 RVA: 0x002F4D50 File Offset: 0x002F2F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != RegressBonusRewardType.Free)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601454D RID: 83277 RVA: 0x002F4DA8 File Offset: 0x002F2FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegressBonusRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != RegressBonusRewardType.Free)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601454E RID: 83278 RVA: 0x002F4DF8 File Offset: 0x002F2FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601454F RID: 83279 RVA: 0x002F4E04 File Offset: 0x002F3004
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (RegressBonusRewardType)input.ReadEnum();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007BDF RID: 31711
		private static readonly MessageParser<RegressBonusRewardInfo> _parser = new MessageParser<RegressBonusRewardInfo>(() => new RegressBonusRewardInfo());

		// Token: 0x04007BE0 RID: 31712
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BE1 RID: 31713
		public const int IdFieldNumber = 1;

		// Token: 0x04007BE2 RID: 31714
		private int id_;

		// Token: 0x04007BE3 RID: 31715
		public const int TypeFieldNumber = 2;

		// Token: 0x04007BE4 RID: 31716
		private RegressBonusRewardType type_;
	}
}
