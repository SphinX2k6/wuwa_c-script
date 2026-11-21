using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200159D RID: 5533
	public sealed class WuWuTaskPack : IMessage<WuWuTaskPack>, IMessage, IEquatable<WuWuTaskPack>, IDeepCloneable<WuWuTaskPack>, IBufferMessage
	{
		// Token: 0x0601D4A4 RID: 119972 RVA: 0x0043D9B9 File Offset: 0x0043BBB9
		[NullableContext(1)]
		public static WuWuTaskPack Create()
		{
			return new WuWuTaskPack();
		}

		// Token: 0x1700631C RID: 25372
		// (get) Token: 0x0601D4A5 RID: 119973 RVA: 0x0043D9C0 File Offset: 0x0043BBC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WuWuTaskPack> Parser
		{
			get
			{
				return WuWuTaskPack._parser;
			}
		}

		// Token: 0x1700631D RID: 25373
		// (get) Token: 0x0601D4A6 RID: 119974 RVA: 0x0043D9C7 File Offset: 0x0043BBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700631E RID: 25374
		// (get) Token: 0x0601D4A7 RID: 119975 RVA: 0x0043D9CA File Offset: 0x0043BBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WuWuTaskPack.Descriptor;
			}
		}

		// Token: 0x0601D4A8 RID: 119976 RVA: 0x0043D9D1 File Offset: 0x0043BBD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskPack()
		{
		}

		// Token: 0x0601D4A9 RID: 119977 RVA: 0x0043D9D9 File Offset: 0x0043BBD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskPack(WuWuTaskPack other) : this()
		{
			this.wuWuPackageId_ = other.wuWuPackageId_;
			this.unLockTime_ = other.unLockTime_;
			this.hadReward_ = other.hadReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D4AA RID: 119978 RVA: 0x0043DA16 File Offset: 0x0043BC16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WuWuTaskPack Clone()
		{
			return new WuWuTaskPack(this);
		}

		// Token: 0x1700631F RID: 25375
		// (get) Token: 0x0601D4AB RID: 119979 RVA: 0x0043DA1E File Offset: 0x0043BC1E
		// (set) Token: 0x0601D4AC RID: 119980 RVA: 0x0043DA26 File Offset: 0x0043BC26
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

		// Token: 0x17006320 RID: 25376
		// (get) Token: 0x0601D4AD RID: 119981 RVA: 0x0043DA2F File Offset: 0x0043BC2F
		// (set) Token: 0x0601D4AE RID: 119982 RVA: 0x0043DA37 File Offset: 0x0043BC37
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

		// Token: 0x17006321 RID: 25377
		// (get) Token: 0x0601D4AF RID: 119983 RVA: 0x0043DA40 File Offset: 0x0043BC40
		// (set) Token: 0x0601D4B0 RID: 119984 RVA: 0x0043DA48 File Offset: 0x0043BC48
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

		// Token: 0x0601D4B1 RID: 119985 RVA: 0x0043DA51 File Offset: 0x0043BC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WuWuTaskPack);
		}

		// Token: 0x0601D4B2 RID: 119986 RVA: 0x0043DA60 File Offset: 0x0043BC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WuWuTaskPack other)
		{
			return other != null && (other == this || (this.WuWuPackageId == other.WuWuPackageId && this.UnLockTime == other.UnLockTime && this.HadReward == other.HadReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D4B3 RID: 119987 RVA: 0x0043DABC File Offset: 0x0043BCBC
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

		// Token: 0x0601D4B4 RID: 119988 RVA: 0x0043DB2D File Offset: 0x0043BD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D4B5 RID: 119989 RVA: 0x0043DB3A File Offset: 0x0043BD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D4B6 RID: 119990 RVA: 0x0043DB44 File Offset: 0x0043BD44
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

		// Token: 0x0601D4B7 RID: 119991 RVA: 0x0043DBB8 File Offset: 0x0043BDB8
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

		// Token: 0x0601D4B8 RID: 119992 RVA: 0x0043DC1C File Offset: 0x0043BE1C
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

		// Token: 0x0601D4B9 RID: 119993 RVA: 0x0043DC80 File Offset: 0x0043BE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D4BA RID: 119994 RVA: 0x0043DC8C File Offset: 0x0043BE8C
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

		// Token: 0x0400A7FE RID: 43006
		private static readonly MessageParser<WuWuTaskPack> _parser = new MessageParser<WuWuTaskPack>(() => new WuWuTaskPack());

		// Token: 0x0400A7FF RID: 43007
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A800 RID: 43008
		public const int WuWuPackageIdFieldNumber = 1;

		// Token: 0x0400A801 RID: 43009
		private int wuWuPackageId_;

		// Token: 0x0400A802 RID: 43010
		public const int UnLockTimeFieldNumber = 2;

		// Token: 0x0400A803 RID: 43011
		private long unLockTime_;

		// Token: 0x0400A804 RID: 43012
		public const int HadRewardFieldNumber = 3;

		// Token: 0x0400A805 RID: 43013
		private bool hadReward_;
	}
}
