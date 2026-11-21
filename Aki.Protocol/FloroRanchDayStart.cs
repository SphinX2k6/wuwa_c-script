using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000597 RID: 1431
	public sealed class FloroRanchDayStart : IMessage<FloroRanchDayStart>, IMessage, IEquatable<FloroRanchDayStart>, IDeepCloneable<FloroRanchDayStart>, IBufferMessage
	{
		// Token: 0x060084C9 RID: 33993 RVA: 0x0013FB38 File Offset: 0x0013DD38
		[NullableContext(1)]
		public static FloroRanchDayStart Create()
		{
			return new FloroRanchDayStart();
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x060084CA RID: 33994 RVA: 0x0013FB3F File Offset: 0x0013DD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x060084CB RID: 33995 RVA: 0x0013FB42 File Offset: 0x0013DD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchDayStart.Descriptor;
			}
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x0013FB49 File Offset: 0x0013DD49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchDayStart()
		{
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x0013FB68 File Offset: 0x0013DD68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchDayStart(FloroRanchDayStart other) : this()
		{
			this.onStageUnit_ = other.onStageUnit_.Clone();
			this.curDay_ = other.curDay_;
			this.curStage_ = other.curStage_;
			this.isUnlimited_ = other.isUnlimited_;
			this.removeUintIncId_ = other.removeUintIncId_.Clone();
			this.totalDay_ = other.totalDay_;
			this.remainDay_ = other.remainDay_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084CE RID: 33998 RVA: 0x0013FBEA File Offset: 0x0013DDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchDayStart Clone()
		{
			return new FloroRanchDayStart(this);
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x060084CF RID: 33999 RVA: 0x0013FBF2 File Offset: 0x0013DDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayUnit> OnStageUnit
		{
			get
			{
				return this.onStageUnit_;
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x060084D0 RID: 34000 RVA: 0x0013FBFA File Offset: 0x0013DDFA
		// (set) Token: 0x060084D1 RID: 34001 RVA: 0x0013FC02 File Offset: 0x0013DE02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurDay
		{
			get
			{
				return this.curDay_;
			}
			set
			{
				this.curDay_ = value;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x060084D2 RID: 34002 RVA: 0x0013FC0B File Offset: 0x0013DE0B
		// (set) Token: 0x060084D3 RID: 34003 RVA: 0x0013FC13 File Offset: 0x0013DE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStage
		{
			get
			{
				return this.curStage_;
			}
			set
			{
				this.curStage_ = value;
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x060084D4 RID: 34004 RVA: 0x0013FC1C File Offset: 0x0013DE1C
		// (set) Token: 0x060084D5 RID: 34005 RVA: 0x0013FC24 File Offset: 0x0013DE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlimited
		{
			get
			{
				return this.isUnlimited_;
			}
			set
			{
				this.isUnlimited_ = value;
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x060084D6 RID: 34006 RVA: 0x0013FC2D File Offset: 0x0013DE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveUintIncId
		{
			get
			{
				return this.removeUintIncId_;
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x060084D7 RID: 34007 RVA: 0x0013FC35 File Offset: 0x0013DE35
		// (set) Token: 0x060084D8 RID: 34008 RVA: 0x0013FC3D File Offset: 0x0013DE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalDay
		{
			get
			{
				return this.totalDay_;
			}
			set
			{
				this.totalDay_ = value;
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x060084D9 RID: 34009 RVA: 0x0013FC46 File Offset: 0x0013DE46
		// (set) Token: 0x060084DA RID: 34010 RVA: 0x0013FC4E File Offset: 0x0013DE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainDay
		{
			get
			{
				return this.remainDay_;
			}
			set
			{
				this.remainDay_ = value;
			}
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x0013FC57 File Offset: 0x0013DE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchDayStart);
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x0013FC68 File Offset: 0x0013DE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchDayStart other)
		{
			return other != null && (other == this || (this.onStageUnit_.Equals(other.onStageUnit_) && this.CurDay == other.CurDay && this.CurStage == other.CurStage && this.IsUnlimited == other.IsUnlimited && this.removeUintIncId_.Equals(other.removeUintIncId_) && this.TotalDay == other.TotalDay && this.RemainDay == other.RemainDay && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x0013FD0C File Offset: 0x0013DF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.onStageUnit_.GetHashCode();
			if (this.CurDay != 0)
			{
				num ^= this.CurDay.GetHashCode();
			}
			if (this.CurStage != 0)
			{
				num ^= this.CurStage.GetHashCode();
			}
			if (this.IsUnlimited)
			{
				num ^= this.IsUnlimited.GetHashCode();
			}
			num ^= this.removeUintIncId_.GetHashCode();
			if (this.TotalDay != 0)
			{
				num ^= this.TotalDay.GetHashCode();
			}
			if (this.RemainDay != 0)
			{
				num ^= this.RemainDay.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084DE RID: 34014 RVA: 0x0013FDCB File Offset: 0x0013DFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060084DF RID: 34015 RVA: 0x0013FDD8 File Offset: 0x0013DFD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x0013FDE4 File Offset: 0x0013DFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.onStageUnit_.WriteTo(ref output, FloroRanchDayStart._repeated_onStageUnit_codec);
			if (this.CurDay != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurDay);
			}
			if (this.CurStage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurStage);
			}
			if (this.IsUnlimited)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsUnlimited);
			}
			this.removeUintIncId_.WriteTo(ref output, FloroRanchDayStart._repeated_removeUintIncId_codec);
			if (this.TotalDay != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TotalDay);
			}
			if (this.RemainDay != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RemainDay);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084E1 RID: 34017 RVA: 0x0013FEB4 File Offset: 0x0013E0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.onStageUnit_.CalculateSize(FloroRanchDayStart._repeated_onStageUnit_codec);
			if (this.CurDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurDay);
			}
			if (this.CurStage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStage);
			}
			if (this.IsUnlimited)
			{
				num += 2;
			}
			num += this.removeUintIncId_.CalculateSize(FloroRanchDayStart._repeated_removeUintIncId_codec);
			if (this.TotalDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalDay);
			}
			if (this.RemainDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainDay);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x0013FF6C File Offset: 0x0013E16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchDayStart other)
		{
			if (other == null)
			{
				return;
			}
			this.onStageUnit_.Add(other.onStageUnit_);
			if (other.CurDay != 0)
			{
				this.CurDay = other.CurDay;
			}
			if (other.CurStage != 0)
			{
				this.CurStage = other.CurStage;
			}
			if (other.IsUnlimited)
			{
				this.IsUnlimited = other.IsUnlimited;
			}
			this.removeUintIncId_.Add(other.removeUintIncId_);
			if (other.TotalDay != 0)
			{
				this.TotalDay = other.TotalDay;
			}
			if (other.RemainDay != 0)
			{
				this.RemainDay = other.RemainDay;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x0014001A File Offset: 0x0013E21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084E4 RID: 34020 RVA: 0x00140024 File Offset: 0x0013E224
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
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.onStageUnit_.AddEntriesFrom(ref input, FloroRanchDayStart._repeated_onStageUnit_codec);
							continue;
						}
						if (num == 16U)
						{
							this.CurDay = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.CurStage = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.IsUnlimited = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.removeUintIncId_.AddEntriesFrom(ref input, FloroRanchDayStart._repeated_removeUintIncId_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.TotalDay = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.RemainDay = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400422A RID: 16938
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400422B RID: 16939
		public const int OnStageUnitFieldNumber = 1;

		// Token: 0x0400422C RID: 16940
		private static readonly FieldCodec<FloroRanchPlayUnit> _repeated_onStageUnit_codec = FieldCodec.ForMessage<FloroRanchPlayUnit>(10U, FloroRanchPlayUnit.Parser);

		// Token: 0x0400422D RID: 16941
		private readonly RepeatedField<FloroRanchPlayUnit> onStageUnit_ = new RepeatedField<FloroRanchPlayUnit>();

		// Token: 0x0400422E RID: 16942
		public const int CurDayFieldNumber = 2;

		// Token: 0x0400422F RID: 16943
		private int curDay_;

		// Token: 0x04004230 RID: 16944
		public const int CurStageFieldNumber = 3;

		// Token: 0x04004231 RID: 16945
		private int curStage_;

		// Token: 0x04004232 RID: 16946
		public const int IsUnlimitedFieldNumber = 4;

		// Token: 0x04004233 RID: 16947
		private bool isUnlimited_;

		// Token: 0x04004234 RID: 16948
		public const int RemoveUintIncIdFieldNumber = 5;

		// Token: 0x04004235 RID: 16949
		private static readonly FieldCodec<int> _repeated_removeUintIncId_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04004236 RID: 16950
		private readonly RepeatedField<int> removeUintIncId_ = new RepeatedField<int>();

		// Token: 0x04004237 RID: 16951
		public const int TotalDayFieldNumber = 6;

		// Token: 0x04004238 RID: 16952
		private int totalDay_;

		// Token: 0x04004239 RID: 16953
		public const int RemainDayFieldNumber = 7;

		// Token: 0x0400423A RID: 16954
		private int remainDay_;
	}
}
