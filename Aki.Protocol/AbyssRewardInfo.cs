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
		// Token: 0x0600137A RID: 4986 RVA: 0x00034D05 File Offset: 0x00032F05
		[NullableContext(1)]
		public static AbyssRewardInfo Create()
		{
			return new AbyssRewardInfo();
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00034D0C File Offset: 0x00032F0C
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
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x00034D13 File Offset: 0x00032F13
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
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x00034D16 File Offset: 0x00032F16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00034D1D File Offset: 0x00032F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardInfo()
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00034D28 File Offset: 0x00032F28
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

		// Token: 0x06001380 RID: 4992 RVA: 0x00034D88 File Offset: 0x00032F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardInfo Clone()
		{
			return new AbyssRewardInfo(this);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x00034D90 File Offset: 0x00032F90
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x00034D98 File Offset: 0x00032F98
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
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x00034DA1 File Offset: 0x00032FA1
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x00034DA9 File Offset: 0x00032FA9
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
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00034DB2 File Offset: 0x00032FB2
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x00034DBA File Offset: 0x00032FBA
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
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00034DC3 File Offset: 0x00032FC3
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x00034DCB File Offset: 0x00032FCB
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
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00034DD4 File Offset: 0x00032FD4
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x00034DDC File Offset: 0x00032FDC
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

		// Token: 0x0600138B RID: 5003 RVA: 0x00034DE5 File Offset: 0x00032FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRewardInfo);
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00034DF4 File Offset: 0x00032FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Rewarded == other.Rewarded && this.Current == other.Current && this.Target == other.Target && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00034E70 File Offset: 0x00033070
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

		// Token: 0x0600138E RID: 5006 RVA: 0x00034F13 File Offset: 0x00033113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00034F20 File Offset: 0x00033120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00034F2C File Offset: 0x0003312C
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

		// Token: 0x06001391 RID: 5009 RVA: 0x00034FD8 File Offset: 0x000331D8
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

		// Token: 0x06001392 RID: 5010 RVA: 0x00035060 File Offset: 0x00033260
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

		// Token: 0x06001393 RID: 5011 RVA: 0x000350EC File Offset: 0x000332EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x000350F8 File Offset: 0x000332F8
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

		// Token: 0x04002012 RID: 8210
		private static readonly MessageParser<AbyssRewardInfo> _parser = new MessageParser<AbyssRewardInfo>(() => new AbyssRewardInfo());

		// Token: 0x04002013 RID: 8211
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002014 RID: 8212
		public const int IdFieldNumber = 1;

		// Token: 0x04002015 RID: 8213
		private int id_;

		// Token: 0x04002016 RID: 8214
		public const int RewardedFieldNumber = 4;

		// Token: 0x04002017 RID: 8215
		private bool rewarded_;

		// Token: 0x04002018 RID: 8216
		public const int CurrentFieldNumber = 6;

		// Token: 0x04002019 RID: 8217
		private int current_;

		// Token: 0x0400201A RID: 8218
		public const int TargetFieldNumber = 7;

		// Token: 0x0400201B RID: 8219
		private int target_;

		// Token: 0x0400201C RID: 8220
		public const int IsFinishFieldNumber = 9;

		// Token: 0x0400201D RID: 8221
		private bool isFinish_;
	}
}
