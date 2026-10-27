using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B57 RID: 2903
	public sealed class NewTrialRoleInfo : IMessage<NewTrialRoleInfo>, IMessage, IEquatable<NewTrialRoleInfo>, IDeepCloneable<NewTrialRoleInfo>, IBufferMessage
	{
		// Token: 0x0600FBA0 RID: 64416 RVA: 0x0024A8CC File Offset: 0x00248ACC
		[NullableContext(1)]
		public static NewTrialRoleInfo Create()
		{
			return new NewTrialRoleInfo();
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600FBA1 RID: 64417 RVA: 0x0024A8D3 File Offset: 0x00248AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTrialRoleInfo> Parser
		{
			get
			{
				return NewTrialRoleInfo._parser;
			}
		}

		// Token: 0x1700334C RID: 13132
		// (get) Token: 0x0600FBA2 RID: 64418 RVA: 0x0024A8DA File Offset: 0x00248ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700334D RID: 13133
		// (get) Token: 0x0600FBA3 RID: 64419 RVA: 0x0024A8DD File Offset: 0x00248ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTrialRoleInfo.Descriptor;
			}
		}

		// Token: 0x0600FBA4 RID: 64420 RVA: 0x0024A8E4 File Offset: 0x00248AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleInfo()
		{
		}

		// Token: 0x0600FBA5 RID: 64421 RVA: 0x0024A8EC File Offset: 0x00248AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleInfo(NewTrialRoleInfo other) : this()
		{
			this.trialRoleId_ = other.trialRoleId_;
			this.worldLv_ = other.worldLv_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FBA6 RID: 64422 RVA: 0x0024A91D File Offset: 0x00248B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTrialRoleInfo Clone()
		{
			return new NewTrialRoleInfo(this);
		}

		// Token: 0x1700334E RID: 13134
		// (get) Token: 0x0600FBA7 RID: 64423 RVA: 0x0024A925 File Offset: 0x00248B25
		// (set) Token: 0x0600FBA8 RID: 64424 RVA: 0x0024A92D File Offset: 0x00248B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrialRoleId
		{
			get
			{
				return this.trialRoleId_;
			}
			set
			{
				this.trialRoleId_ = value;
			}
		}

		// Token: 0x1700334F RID: 13135
		// (get) Token: 0x0600FBA9 RID: 64425 RVA: 0x0024A936 File Offset: 0x00248B36
		// (set) Token: 0x0600FBAA RID: 64426 RVA: 0x0024A93E File Offset: 0x00248B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WorldLv
		{
			get
			{
				return this.worldLv_;
			}
			set
			{
				this.worldLv_ = value;
			}
		}

		// Token: 0x0600FBAB RID: 64427 RVA: 0x0024A947 File Offset: 0x00248B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTrialRoleInfo);
		}

		// Token: 0x0600FBAC RID: 64428 RVA: 0x0024A955 File Offset: 0x00248B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTrialRoleInfo other)
		{
			return other != null && (other == this || (this.TrialRoleId == other.TrialRoleId && this.WorldLv == other.WorldLv && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FBAD RID: 64429 RVA: 0x0024A994 File Offset: 0x00248B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrialRoleId != 0)
			{
				num ^= this.TrialRoleId.GetHashCode();
			}
			if (this.WorldLv != 0)
			{
				num ^= this.WorldLv.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FBAE RID: 64430 RVA: 0x0024A9EC File Offset: 0x00248BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FBAF RID: 64431 RVA: 0x0024A9F9 File Offset: 0x00248BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FBB0 RID: 64432 RVA: 0x0024AA04 File Offset: 0x00248C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrialRoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TrialRoleId);
			}
			if (this.WorldLv != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.WorldLv);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FBB1 RID: 64433 RVA: 0x0024AA5C File Offset: 0x00248C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrialRoleId);
			}
			if (this.WorldLv != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WorldLv);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FBB2 RID: 64434 RVA: 0x0024AAB4 File Offset: 0x00248CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTrialRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrialRoleId != 0)
			{
				this.TrialRoleId = other.TrialRoleId;
			}
			if (other.WorldLv != 0)
			{
				this.WorldLv = other.WorldLv;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FBB3 RID: 64435 RVA: 0x0024AB04 File Offset: 0x00248D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FBB4 RID: 64436 RVA: 0x0024AB10 File Offset: 0x00248D10
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
						this.WorldLv = input.ReadInt32();
					}
				}
				else
				{
					this.TrialRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400648F RID: 25743
		private static readonly MessageParser<NewTrialRoleInfo> _parser = new MessageParser<NewTrialRoleInfo>(() => new NewTrialRoleInfo());

		// Token: 0x04006490 RID: 25744
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006491 RID: 25745
		public const int TrialRoleIdFieldNumber = 1;

		// Token: 0x04006492 RID: 25746
		private int trialRoleId_;

		// Token: 0x04006493 RID: 25747
		public const int WorldLvFieldNumber = 2;

		// Token: 0x04006494 RID: 25748
		private int worldLv_;
	}
}
