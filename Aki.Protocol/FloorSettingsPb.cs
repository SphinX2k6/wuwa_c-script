using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A5 RID: 1445
	public sealed class FloorSettingsPb : IMessage<FloorSettingsPb>, IMessage, IEquatable<FloorSettingsPb>, IDeepCloneable<FloorSettingsPb>, IBufferMessage
	{
		// Token: 0x0600859D RID: 34205 RVA: 0x001411A9 File Offset: 0x0013F3A9
		[NullableContext(1)]
		public static FloorSettingsPb Create()
		{
			return new FloorSettingsPb();
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x0600859E RID: 34206 RVA: 0x001411B0 File Offset: 0x0013F3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x0600859F RID: 34207 RVA: 0x001411B3 File Offset: 0x0013F3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloorSettingsPb.Descriptor;
			}
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x001411BA File Offset: 0x0013F3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloorSettingsPb()
		{
		}

		// Token: 0x060085A1 RID: 34209 RVA: 0x001411D8 File Offset: 0x0013F3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloorSettingsPb(FloorSettingsPb other) : this()
		{
			this.meshPath_ = other.meshPath_;
			this.materialPath_ = other.materialPath_;
			this.scaleX_ = other.scaleX_;
			this.scaleY_ = other.scaleY_;
			this.showTime_ = other.showTime_;
			this.disappearTime_ = other.disappearTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085A2 RID: 34210 RVA: 0x00141244 File Offset: 0x0013F444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloorSettingsPb Clone()
		{
			return new FloorSettingsPb(this);
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x060085A3 RID: 34211 RVA: 0x0014124C File Offset: 0x0013F44C
		// (set) Token: 0x060085A4 RID: 34212 RVA: 0x00141254 File Offset: 0x0013F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MeshPath
		{
			get
			{
				return this.meshPath_;
			}
			set
			{
				this.meshPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x060085A5 RID: 34213 RVA: 0x00141267 File Offset: 0x0013F467
		// (set) Token: 0x060085A6 RID: 34214 RVA: 0x0014126F File Offset: 0x0013F46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MaterialPath
		{
			get
			{
				return this.materialPath_;
			}
			set
			{
				this.materialPath_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x060085A7 RID: 34215 RVA: 0x00141282 File Offset: 0x0013F482
		// (set) Token: 0x060085A8 RID: 34216 RVA: 0x0014128A File Offset: 0x0013F48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ScaleX
		{
			get
			{
				return this.scaleX_;
			}
			set
			{
				this.scaleX_ = value;
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x00141293 File Offset: 0x0013F493
		// (set) Token: 0x060085AA RID: 34218 RVA: 0x0014129B File Offset: 0x0013F49B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ScaleY
		{
			get
			{
				return this.scaleY_;
			}
			set
			{
				this.scaleY_ = value;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x060085AB RID: 34219 RVA: 0x001412A4 File Offset: 0x0013F4A4
		// (set) Token: 0x060085AC RID: 34220 RVA: 0x001412AC File Offset: 0x0013F4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float ShowTime
		{
			get
			{
				return this.showTime_;
			}
			set
			{
				this.showTime_ = value;
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x060085AD RID: 34221 RVA: 0x001412B5 File Offset: 0x0013F4B5
		// (set) Token: 0x060085AE RID: 34222 RVA: 0x001412BD File Offset: 0x0013F4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float DisappearTime
		{
			get
			{
				return this.disappearTime_;
			}
			set
			{
				this.disappearTime_ = value;
			}
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x001412C6 File Offset: 0x0013F4C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloorSettingsPb);
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x001412D4 File Offset: 0x0013F4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloorSettingsPb other)
		{
			return other != null && (other == this || (!(this.MeshPath != other.MeshPath) && !(this.MaterialPath != other.MaterialPath) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScaleX, other.ScaleX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScaleY, other.ScaleY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ShowTime, other.ShowTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DisappearTime, other.DisappearTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x00141390 File Offset: 0x0013F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MeshPath.Length != 0)
			{
				num ^= this.MeshPath.GetHashCode();
			}
			if (this.MaterialPath.Length != 0)
			{
				num ^= this.MaterialPath.GetHashCode();
			}
			if (this.ScaleX != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ScaleX);
			}
			if (this.ScaleY != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ScaleY);
			}
			if (this.ShowTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.ShowTime);
			}
			if (this.DisappearTime != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DisappearTime);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085B2 RID: 34226 RVA: 0x0014146C File Offset: 0x0013F66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060085B3 RID: 34227 RVA: 0x00141479 File Offset: 0x0013F679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085B4 RID: 34228 RVA: 0x00141484 File Offset: 0x0013F684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MeshPath.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.MeshPath);
			}
			if (this.MaterialPath.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.MaterialPath);
			}
			if (this.ScaleX != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.ScaleX);
			}
			if (this.ScaleY != 0f)
			{
				output.WriteRawTag(37);
				output.WriteFloat(this.ScaleY);
			}
			if (this.ShowTime != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.ShowTime);
			}
			if (this.DisappearTime != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.DisappearTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x0014156C File Offset: 0x0013F76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MeshPath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MeshPath);
			}
			if (this.MaterialPath.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MaterialPath);
			}
			if (this.ScaleX != 0f)
			{
				num += 5;
			}
			if (this.ScaleY != 0f)
			{
				num += 5;
			}
			if (this.ShowTime != 0f)
			{
				num += 5;
			}
			if (this.DisappearTime != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085B6 RID: 34230 RVA: 0x00141610 File Offset: 0x0013F810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloorSettingsPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MeshPath.Length != 0)
			{
				this.MeshPath = other.MeshPath;
			}
			if (other.MaterialPath.Length != 0)
			{
				this.MaterialPath = other.MaterialPath;
			}
			if (other.ScaleX != 0f)
			{
				this.ScaleX = other.ScaleX;
			}
			if (other.ScaleY != 0f)
			{
				this.ScaleY = other.ScaleY;
			}
			if (other.ShowTime != 0f)
			{
				this.ShowTime = other.ShowTime;
			}
			if (other.DisappearTime != 0f)
			{
				this.DisappearTime = other.DisappearTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060085B7 RID: 34231 RVA: 0x001416CE File Offset: 0x0013F8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x001416D8 File Offset: 0x0013F8D8
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
				if (num <= 29U)
				{
					if (num == 10U)
					{
						this.MeshPath = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						this.MaterialPath = input.ReadString();
						continue;
					}
					if (num == 29U)
					{
						this.ScaleX = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 37U)
					{
						this.ScaleY = input.ReadFloat();
						continue;
					}
					if (num == 45U)
					{
						this.ShowTime = input.ReadFloat();
						continue;
					}
					if (num == 53U)
					{
						this.DisappearTime = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004208 RID: 16904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004209 RID: 16905
		public const int MeshPathFieldNumber = 1;

		// Token: 0x0400420A RID: 16906
		private string meshPath_ = "";

		// Token: 0x0400420B RID: 16907
		public const int MaterialPathFieldNumber = 2;

		// Token: 0x0400420C RID: 16908
		private string materialPath_ = "";

		// Token: 0x0400420D RID: 16909
		public const int ScaleXFieldNumber = 3;

		// Token: 0x0400420E RID: 16910
		private float scaleX_;

		// Token: 0x0400420F RID: 16911
		public const int ScaleYFieldNumber = 4;

		// Token: 0x04004210 RID: 16912
		private float scaleY_;

		// Token: 0x04004211 RID: 16913
		public const int ShowTimeFieldNumber = 5;

		// Token: 0x04004212 RID: 16914
		private float showTime_;

		// Token: 0x04004213 RID: 16915
		public const int DisappearTimeFieldNumber = 6;

		// Token: 0x04004214 RID: 16916
		private float disappearTime_;
	}
}
