using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200003F RID: 63
	public sealed class AbyssRewardInfo : IMessage<AbyssRewardInfo>, IMessage, IEquatable<AbyssRewardInfo>, IDeepCloneable<AbyssRewardInfo>, IBufferMessage
	{
		// Token: 0x060013A5 RID: 5029 RVA: 0x000352B9 File Offset: 0x000334B9
		[NullableContext(1)]
		public static AbyssRewardInfo Create()
		{
			return new AbyssRewardInfo();
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x000352C0 File Offset: 0x000334C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssRewardInfo> Parser
		{
			get
			{
				return AbyssRewardInfo._parser;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x000352C7 File Offset: 0x000334C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x000352CA File Offset: 0x000334CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRewardInfo.Descriptor;
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x000352D1 File Offset: 0x000334D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardInfo()
		{
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x000352DC File Offset: 0x000334DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardInfo(AbyssRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.rewarded_ = other.rewarded_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0003533C File Offset: 0x0003353C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardInfo Clone()
		{
			return new AbyssRewardInfo(this);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00035344 File Offset: 0x00033544
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x0003534C File Offset: 0x0003354C
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x00035355 File Offset: 0x00033555
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x0003535D File Offset: 0x0003355D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x00035366 File Offset: 0x00033566
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0003536E File Offset: 0x0003356E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x00035377 File Offset: 0x00033577
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0003537F File Offset: 0x0003357F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00035388 File Offset: 0x00033588
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x00035390 File Offset: 0x00033590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00035399 File Offset: 0x00033599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRewardInfo);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x000353A8 File Offset: 0x000335A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Rewarded == other.Rewarded && this.Current == other.Current && this.Target == other.Target && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00035424 File Offset: 0x00033624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000354C7 File Offset: 0x000336C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000354D4 File Offset: 0x000336D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000354E0 File Offset: 0x000336E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.Rewarded);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Target);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0003558C File Offset: 0x0003378C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00035614 File Offset: 0x00033814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000356A0 File Offset: 0x000338A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000356AC File Offset: 0x000338AC
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Rewarded = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.Current = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.IsFinish = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002068 RID: 8296
		private static readonly MessageParser<AbyssRewardInfo> _parser = new MessageParser<AbyssRewardInfo>(() => new AbyssRewardInfo());

		// Token: 0x04002069 RID: 8297
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400206A RID: 8298
		public const int IdFieldNumber = 1;

		// Token: 0x0400206B RID: 8299
		private int id_;

		// Token: 0x0400206C RID: 8300
		public const int RewardedFieldNumber = 4;

		// Token: 0x0400206D RID: 8301
		private bool rewarded_;

		// Token: 0x0400206E RID: 8302
		public const int CurrentFieldNumber = 6;

		// Token: 0x0400206F RID: 8303
		private int current_;

		// Token: 0x04002070 RID: 8304
		public const int TargetFieldNumber = 7;

		// Token: 0x04002071 RID: 8305
		private int target_;

		// Token: 0x04002072 RID: 8306
		public const int IsFinishFieldNumber = 9;

		// Token: 0x04002073 RID: 8307
		private bool isFinish_;
	}
}
