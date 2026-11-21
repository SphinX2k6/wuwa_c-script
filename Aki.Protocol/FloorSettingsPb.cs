using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000590 RID: 1424
	public sealed class FloorSettingsPb : IMessage<FloorSettingsPb>, IMessage, IEquatable<FloorSettingsPb>, IDeepCloneable<FloorSettingsPb>, IBufferMessage
	{
		// Token: 0x06008435 RID: 33845 RVA: 0x0013E5A1 File Offset: 0x0013C7A1
		[NullableContext(1)]
		public static FloorSettingsPb Create()
		{
			return new FloorSettingsPb();
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06008436 RID: 33846 RVA: 0x0013E5A8 File Offset: 0x0013C7A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06008437 RID: 33847 RVA: 0x0013E5AB File Offset: 0x0013C7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloorSettingsPb.Descriptor;
			}
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x0013E5B2 File Offset: 0x0013C7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloorSettingsPb()
		{
		}

		// Token: 0x06008439 RID: 33849 RVA: 0x0013E5D0 File Offset: 0x0013C7D0
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

		// Token: 0x0600843A RID: 33850 RVA: 0x0013E63C File Offset: 0x0013C83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloorSettingsPb Clone()
		{
			return new FloorSettingsPb(this);
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x0600843B RID: 33851 RVA: 0x0013E644 File Offset: 0x0013C844
		// (set) Token: 0x0600843C RID: 33852 RVA: 0x0013E64C File Offset: 0x0013C84C
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

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x0600843D RID: 33853 RVA: 0x0013E65F File Offset: 0x0013C85F
		// (set) Token: 0x0600843E RID: 33854 RVA: 0x0013E667 File Offset: 0x0013C867
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

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x0600843F RID: 33855 RVA: 0x0013E67A File Offset: 0x0013C87A
		// (set) Token: 0x06008440 RID: 33856 RVA: 0x0013E682 File Offset: 0x0013C882
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

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06008441 RID: 33857 RVA: 0x0013E68B File Offset: 0x0013C88B
		// (set) Token: 0x06008442 RID: 33858 RVA: 0x0013E693 File Offset: 0x0013C893
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

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06008443 RID: 33859 RVA: 0x0013E69C File Offset: 0x0013C89C
		// (set) Token: 0x06008444 RID: 33860 RVA: 0x0013E6A4 File Offset: 0x0013C8A4
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

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06008445 RID: 33861 RVA: 0x0013E6AD File Offset: 0x0013C8AD
		// (set) Token: 0x06008446 RID: 33862 RVA: 0x0013E6B5 File Offset: 0x0013C8B5
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

		// Token: 0x06008447 RID: 33863 RVA: 0x0013E6BE File Offset: 0x0013C8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloorSettingsPb);
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x0013E6CC File Offset: 0x0013C8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloorSettingsPb other)
		{
			return other != null && (other == this || (!(this.MeshPath != other.MeshPath) && !(this.MaterialPath != other.MaterialPath) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScaleX, other.ScaleX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ScaleY, other.ScaleY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.ShowTime, other.ShowTime) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DisappearTime, other.DisappearTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x0013E788 File Offset: 0x0013C988
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

		// Token: 0x0600844A RID: 33866 RVA: 0x0013E864 File Offset: 0x0013CA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x0013E871 File Offset: 0x0013CA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x0013E87C File Offset: 0x0013CA7C
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

		// Token: 0x0600844D RID: 33869 RVA: 0x0013E964 File Offset: 0x0013CB64
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

		// Token: 0x0600844E RID: 33870 RVA: 0x0013EA08 File Offset: 0x0013CC08
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

		// Token: 0x0600844F RID: 33871 RVA: 0x0013EAC6 File Offset: 0x0013CCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x0013EAD0 File Offset: 0x0013CCD0
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

		// Token: 0x040041FE RID: 16894
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041FF RID: 16895
		public const int MeshPathFieldNumber = 1;

		// Token: 0x04004200 RID: 16896
		private string meshPath_ = "";

		// Token: 0x04004201 RID: 16897
		public const int MaterialPathFieldNumber = 2;

		// Token: 0x04004202 RID: 16898
		private string materialPath_ = "";

		// Token: 0x04004203 RID: 16899
		public const int ScaleXFieldNumber = 3;

		// Token: 0x04004204 RID: 16900
		private float scaleX_;

		// Token: 0x04004205 RID: 16901
		public const int ScaleYFieldNumber = 4;

		// Token: 0x04004206 RID: 16902
		private float scaleY_;

		// Token: 0x04004207 RID: 16903
		public const int ShowTimeFieldNumber = 5;

		// Token: 0x04004208 RID: 16904
		private float showTime_;

		// Token: 0x04004209 RID: 16905
		public const int DisappearTimeFieldNumber = 6;

		// Token: 0x0400420A RID: 16906
		private float disappearTime_;
	}
}
