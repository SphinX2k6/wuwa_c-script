using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001527 RID: 5415
	public sealed class WuWuTaskPack : IMessage<WuWuTaskPack>, IMessage, IEquatable<WuWuTaskPack>, IDeepCloneable<WuWuTaskPack>, IBufferMessage
	{
		// Token: 0x0601C9DD RID: 117213 RVA: 0x00421EFD File Offset: 0x004200FD
		[NullableContext(1)]
		public static WuWuTaskPack Create()
		{
			return new WuWuTaskPack();
		}

		// Token: 0x1700607B RID: 24699
		// (get) Token: 0x0601C9DE RID: 117214 RVA: 0x00421F04 File Offset: 0x00420104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WuWuTaskPack> Parser
		{
			get
			{
				return WuWuTaskPack._parser;
			}
		}

		// Token: 0x1700607C RID: 24700
		// (get) Token: 0x0601C9DF RID: 117215 RVA: 0x00421F0B File Offset: 0x0042010B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700607D RID: 24701
		// (get) Token: 0x0601C9E0 RID: 117216 RVA: 0x00421F0E File Offset: 0x0042010E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuTaskPack.Descriptor;
			}
		}

		// Token: 0x0601C9E1 RID: 117217 RVA: 0x00421F15 File Offset: 0x00420115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskPack()
		{
		}

		// Token: 0x0601C9E2 RID: 117218 RVA: 0x00421F1D File Offset: 0x0042011D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskPack(WuWuTaskPack other) : this()
		{
			this.wuWuPackageId_ = other.wuWuPackageId_;
			this.unLockTime_ = other.unLockTime_;
			this.hadReward_ = other.hadReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C9E3 RID: 117219 RVA: 0x00421F5A File Offset: 0x0042015A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskPack Clone()
		{
			return new WuWuTaskPack(this);
		}

		// Token: 0x1700607E RID: 24702
		// (get) Token: 0x0601C9E4 RID: 117220 RVA: 0x00421F62 File Offset: 0x00420162
		// (set) Token: 0x0601C9E5 RID: 117221 RVA: 0x00421F6A File Offset: 0x0042016A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WuWuPackageId
		{
			get
			{
				return this.wuWuPackageId_;
			}
			set
			{
				this.wuWuPackageId_ = value;
			}
		}

		// Token: 0x1700607F RID: 24703
		// (get) Token: 0x0601C9E6 RID: 117222 RVA: 0x00421F73 File Offset: 0x00420173
		// (set) Token: 0x0601C9E7 RID: 117223 RVA: 0x00421F7B File Offset: 0x0042017B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnLockTime
		{
			get
			{
				return this.unLockTime_;
			}
			set
			{
				this.unLockTime_ = value;
			}
		}

		// Token: 0x17006080 RID: 24704
		// (get) Token: 0x0601C9E8 RID: 117224 RVA: 0x00421F84 File Offset: 0x00420184
		// (set) Token: 0x0601C9E9 RID: 117225 RVA: 0x00421F8C File Offset: 0x0042018C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HadReward
		{
			get
			{
				return this.hadReward_;
			}
			set
			{
				this.hadReward_ = value;
			}
		}

		// Token: 0x0601C9EA RID: 117226 RVA: 0x00421F95 File Offset: 0x00420195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuTaskPack);
		}

		// Token: 0x0601C9EB RID: 117227 RVA: 0x00421FA4 File Offset: 0x004201A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuTaskPack other)
		{
			return other != null && (other == this || (this.WuWuPackageId == other.WuWuPackageId && this.UnLockTime == other.UnLockTime && this.HadReward == other.HadReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C9EC RID: 117228 RVA: 0x00422000 File Offset: 0x00420200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WuWuPackageId != 0)
			{
				num ^= this.WuWuPackageId.GetHashCode();
			}
			if (this.UnLockTime != 0L)
			{
				num ^= this.UnLockTime.GetHashCode();
			}
			if (this.HadReward)
			{
				num ^= this.HadReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C9ED RID: 117229 RVA: 0x00422071 File Offset: 0x00420271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C9EE RID: 117230 RVA: 0x0042207E File Offset: 0x0042027E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C9EF RID: 117231 RVA: 0x00422088 File Offset: 0x00420288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WuWuPackageId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WuWuPackageId);
			}
			if (this.UnLockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnLockTime);
			}
			if (this.HadReward)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HadReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C9F0 RID: 117232 RVA: 0x004220FC File Offset: 0x004202FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WuWuPackageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WuWuPackageId);
			}
			if (this.UnLockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnLockTime);
			}
			if (this.HadReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C9F1 RID: 117233 RVA: 0x00422160 File Offset: 0x00420360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WuWuTaskPack other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WuWuPackageId != 0)
			{
				this.WuWuPackageId = other.WuWuPackageId;
			}
			if (other.UnLockTime != 0L)
			{
				this.UnLockTime = other.UnLockTime;
			}
			if (other.HadReward)
			{
				this.HadReward = other.HadReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C9F2 RID: 117234 RVA: 0x004221C4 File Offset: 0x004203C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C9F3 RID: 117235 RVA: 0x004221D0 File Offset: 0x004203D0
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HadReward = input.ReadBool();
						}
					}
					else
					{
						this.UnLockTime = input.ReadInt64();
					}
				}
				else
				{
					this.WuWuPackageId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A3A5 RID: 41893
		private static readonly MessageParser<WuWuTaskPack> _parser = new MessageParser<WuWuTaskPack>(() => new WuWuTaskPack());

		// Token: 0x0400A3A6 RID: 41894
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A3A7 RID: 41895
		public const int WuWuPackageIdFieldNumber = 1;

		// Token: 0x0400A3A8 RID: 41896
		private int wuWuPackageId_;

		// Token: 0x0400A3A9 RID: 41897
		public const int UnLockTimeFieldNumber = 2;

		// Token: 0x0400A3AA RID: 41898
		private long unLockTime_;

		// Token: 0x0400A3AB RID: 41899
		public const int HadRewardFieldNumber = 3;

		// Token: 0x0400A3AC RID: 41900
		private bool hadReward_;
	}
}
