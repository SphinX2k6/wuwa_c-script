using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000761 RID: 1889
	public sealed class HonamiStoryEnterCtx : IMessage<HonamiStoryEnterCtx>, IMessage, IEquatable<HonamiStoryEnterCtx>, IDeepCloneable<HonamiStoryEnterCtx>, IBufferMessage
	{
		// Token: 0x0600AB2D RID: 43821 RVA: 0x0019BFD4 File Offset: 0x0019A1D4
		[NullableContext(1)]
		public static HonamiStoryEnterCtx Create()
		{
			return new HonamiStoryEnterCtx();
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x0600AB2E RID: 43822 RVA: 0x0019BFDB File Offset: 0x0019A1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x0600AB2F RID: 43823 RVA: 0x0019BFDE File Offset: 0x0019A1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryEnterCtx.Descriptor;
			}
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x0019BFE5 File Offset: 0x0019A1E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnterCtx()
		{
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x0019BFF0 File Offset: 0x0019A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnterCtx(HonamiStoryEnterCtx other) : this()
		{
			this.isUpTower_ = other.isUpTower_;
			this.dangerLevel_ = other.dangerLevel_;
			this.activityId_ = other.activityId_;
			this.buySafeLeave_ = other.buySafeLeave_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x0019C044 File Offset: 0x0019A244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnterCtx Clone()
		{
			return new HonamiStoryEnterCtx(this);
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x0019C04C File Offset: 0x0019A24C
		// (set) Token: 0x0600AB34 RID: 43828 RVA: 0x0019C054 File Offset: 0x0019A254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUpTower
		{
			get
			{
				return this.isUpTower_;
			}
			set
			{
				this.isUpTower_ = value;
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x0600AB35 RID: 43829 RVA: 0x0019C05D File Offset: 0x0019A25D
		// (set) Token: 0x0600AB36 RID: 43830 RVA: 0x0019C065 File Offset: 0x0019A265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangerLevel
		{
			get
			{
				return this.dangerLevel_;
			}
			set
			{
				this.dangerLevel_ = value;
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x0600AB37 RID: 43831 RVA: 0x0019C06E File Offset: 0x0019A26E
		// (set) Token: 0x0600AB38 RID: 43832 RVA: 0x0019C076 File Offset: 0x0019A276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x0600AB39 RID: 43833 RVA: 0x0019C07F File Offset: 0x0019A27F
		// (set) Token: 0x0600AB3A RID: 43834 RVA: 0x0019C087 File Offset: 0x0019A287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BuySafeLeave
		{
			get
			{
				return this.buySafeLeave_;
			}
			set
			{
				this.buySafeLeave_ = value;
			}
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x0019C090 File Offset: 0x0019A290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryEnterCtx);
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x0019C0A0 File Offset: 0x0019A2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryEnterCtx other)
		{
			return other != null && (other == this || (this.IsUpTower == other.IsUpTower && this.DangerLevel == other.DangerLevel && this.ActivityId == other.ActivityId && this.BuySafeLeave == other.BuySafeLeave && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x0019C10C File Offset: 0x0019A30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsUpTower)
			{
				num ^= this.IsUpTower.GetHashCode();
			}
			if (this.DangerLevel != 0)
			{
				num ^= this.DangerLevel.GetHashCode();
			}
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.BuySafeLeave)
			{
				num ^= this.BuySafeLeave.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x0019C196 File Offset: 0x0019A396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB3F RID: 43839 RVA: 0x0019C1A3 File Offset: 0x0019A3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x0019C1AC File Offset: 0x0019A3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsUpTower)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsUpTower);
			}
			if (this.DangerLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DangerLevel);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this.BuySafeLeave)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.BuySafeLeave);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x0019C23C File Offset: 0x0019A43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsUpTower)
			{
				num += 2;
			}
			if (this.DangerLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangerLevel);
			}
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.BuySafeLeave)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x0019C2AC File Offset: 0x0019A4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsUpTower)
			{
				this.IsUpTower = other.IsUpTower;
			}
			if (other.DangerLevel != 0)
			{
				this.DangerLevel = other.DangerLevel;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.BuySafeLeave)
			{
				this.BuySafeLeave = other.BuySafeLeave;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x0019C324 File Offset: 0x0019A524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x0019C330 File Offset: 0x0019A530
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.IsUpTower = input.ReadBool();
						continue;
					}
					if (num == 16U)
					{
						this.DangerLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BuySafeLeave = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E12 RID: 19986
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E13 RID: 19987
		public const int IsUpTowerFieldNumber = 1;

		// Token: 0x04004E14 RID: 19988
		private bool isUpTower_;

		// Token: 0x04004E15 RID: 19989
		public const int DangerLevelFieldNumber = 2;

		// Token: 0x04004E16 RID: 19990
		private int dangerLevel_;

		// Token: 0x04004E17 RID: 19991
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004E18 RID: 19992
		private int activityId_;

		// Token: 0x04004E19 RID: 19993
		public const int BuySafeLeaveFieldNumber = 4;

		// Token: 0x04004E1A RID: 19994
		private bool buySafeLeave_;
	}
}
