using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D2B RID: 3371
	public sealed class PhotoFightLevelPb : IMessage<PhotoFightLevelPb>, IMessage, IEquatable<PhotoFightLevelPb>, IDeepCloneable<PhotoFightLevelPb>, IBufferMessage
	{
		// Token: 0x06012338 RID: 74552 RVA: 0x002A8759 File Offset: 0x002A6959
		[NullableContext(1)]
		public static PhotoFightLevelPb Create()
		{
			return new PhotoFightLevelPb();
		}

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x06012339 RID: 74553 RVA: 0x002A8760 File Offset: 0x002A6960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoFightLevelPb> Parser
		{
			get
			{
				return PhotoFightLevelPb._parser;
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0601233A RID: 74554 RVA: 0x002A8767 File Offset: 0x002A6967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0601233B RID: 74555 RVA: 0x002A876A File Offset: 0x002A696A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightLevelPb.Descriptor;
			}
		}

		// Token: 0x0601233C RID: 74556 RVA: 0x002A8771 File Offset: 0x002A6971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelPb()
		{
		}

		// Token: 0x0601233D RID: 74557 RVA: 0x002A8784 File Offset: 0x002A6984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelPb(PhotoFightLevelPb other) : this()
		{
			this.levelId_ = other.levelId_;
			this.instId_ = other.instId_;
			this.roles_ = other.roles_.Clone();
			this.clearTimes_ = other.clearTimes_;
			this.isOpen_ = other.isOpen_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601233E RID: 74558 RVA: 0x002A87E9 File Offset: 0x002A69E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelPb Clone()
		{
			return new PhotoFightLevelPb(this);
		}

		// Token: 0x17003C52 RID: 15442
		// (get) Token: 0x0601233F RID: 74559 RVA: 0x002A87F1 File Offset: 0x002A69F1
		// (set) Token: 0x06012340 RID: 74560 RVA: 0x002A87F9 File Offset: 0x002A69F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17003C53 RID: 15443
		// (get) Token: 0x06012341 RID: 74561 RVA: 0x002A8802 File Offset: 0x002A6A02
		// (set) Token: 0x06012342 RID: 74562 RVA: 0x002A880A File Offset: 0x002A6A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x06012343 RID: 74563 RVA: 0x002A8813 File Offset: 0x002A6A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Roles
		{
			get
			{
				return this.roles_;
			}
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x06012344 RID: 74564 RVA: 0x002A881B File Offset: 0x002A6A1B
		// (set) Token: 0x06012345 RID: 74565 RVA: 0x002A8823 File Offset: 0x002A6A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ClearTimes
		{
			get
			{
				return this.clearTimes_;
			}
			set
			{
				this.clearTimes_ = value;
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x06012346 RID: 74566 RVA: 0x002A882C File Offset: 0x002A6A2C
		// (set) Token: 0x06012347 RID: 74567 RVA: 0x002A8834 File Offset: 0x002A6A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOpen
		{
			get
			{
				return this.isOpen_;
			}
			set
			{
				this.isOpen_ = value;
			}
		}

		// Token: 0x06012348 RID: 74568 RVA: 0x002A883D File Offset: 0x002A6A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightLevelPb);
		}

		// Token: 0x06012349 RID: 74569 RVA: 0x002A884C File Offset: 0x002A6A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightLevelPb other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.InstId == other.InstId && this.roles_.Equals(other.roles_) && this.ClearTimes == other.ClearTimes && this.IsOpen == other.IsOpen && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601234A RID: 74570 RVA: 0x002A88CC File Offset: 0x002A6ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.roles_.GetHashCode();
			if (this.ClearTimes != 0)
			{
				num ^= this.ClearTimes.GetHashCode();
			}
			if (this.IsOpen)
			{
				num ^= this.IsOpen.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601234B RID: 74571 RVA: 0x002A8964 File Offset: 0x002A6B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601234C RID: 74572 RVA: 0x002A8971 File Offset: 0x002A6B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601234D RID: 74573 RVA: 0x002A897C File Offset: 0x002A6B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.InstId);
			}
			this.roles_.WriteTo(ref output, PhotoFightLevelPb._repeated_roles_codec);
			if (this.ClearTimes != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ClearTimes);
			}
			if (this.IsOpen)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsOpen);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601234E RID: 74574 RVA: 0x002A8A20 File Offset: 0x002A6C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.roles_.CalculateSize(PhotoFightLevelPb._repeated_roles_codec);
			if (this.ClearTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ClearTimes);
			}
			if (this.IsOpen)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601234F RID: 74575 RVA: 0x002A8AB0 File Offset: 0x002A6CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightLevelPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.roles_.Add(other.roles_);
			if (other.ClearTimes != 0)
			{
				this.ClearTimes = other.ClearTimes;
			}
			if (other.IsOpen)
			{
				this.IsOpen = other.IsOpen;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012350 RID: 74576 RVA: 0x002A8B39 File Offset: 0x002A6D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012351 RID: 74577 RVA: 0x002A8B44 File Offset: 0x002A6D44
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.LevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						goto IL_60;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_60;
					}
					if (num == 32U)
					{
						this.ClearTimes = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.IsOpen = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_60:
				this.roles_.AddEntriesFrom(ref input, PhotoFightLevelPb._repeated_roles_codec);
			}
		}

		// Token: 0x040071A7 RID: 29095
		private static readonly MessageParser<PhotoFightLevelPb> _parser = new MessageParser<PhotoFightLevelPb>(() => new PhotoFightLevelPb());

		// Token: 0x040071A8 RID: 29096
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071A9 RID: 29097
		public const int LevelIdFieldNumber = 1;

		// Token: 0x040071AA RID: 29098
		private int levelId_;

		// Token: 0x040071AB RID: 29099
		public const int InstIdFieldNumber = 2;

		// Token: 0x040071AC RID: 29100
		private int instId_;

		// Token: 0x040071AD RID: 29101
		public const int RolesFieldNumber = 3;

		// Token: 0x040071AE RID: 29102
		private static readonly FieldCodec<int> _repeated_roles_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040071AF RID: 29103
		private readonly RepeatedField<int> roles_ = new RepeatedField<int>();

		// Token: 0x040071B0 RID: 29104
		public const int ClearTimesFieldNumber = 4;

		// Token: 0x040071B1 RID: 29105
		private int clearTimes_;

		// Token: 0x040071B2 RID: 29106
		public const int IsOpenFieldNumber = 5;

		// Token: 0x040071B3 RID: 29107
		private bool isOpen_;
	}
}
