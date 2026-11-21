using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000986 RID: 2438
	public sealed class MapTeleportByLocationOp : IMessage<MapTeleportByLocationOp>, IMessage, IEquatable<MapTeleportByLocationOp>, IDeepCloneable<MapTeleportByLocationOp>, IBufferMessage
	{
		// Token: 0x0600D69A RID: 54938 RVA: 0x001F9427 File Offset: 0x001F7627
		[NullableContext(1)]
		public static MapTeleportByLocationOp Create()
		{
			return new MapTeleportByLocationOp();
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x0600D69B RID: 54939 RVA: 0x001F942E File Offset: 0x001F762E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x0600D69C RID: 54940 RVA: 0x001F9431 File Offset: 0x001F7631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTeleportByLocationOp.Descriptor;
			}
		}

		// Token: 0x0600D69D RID: 54941 RVA: 0x001F9438 File Offset: 0x001F7638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTeleportByLocationOp()
		{
		}

		// Token: 0x0600D69E RID: 54942 RVA: 0x001F944C File Offset: 0x001F764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTeleportByLocationOp(MapTeleportByLocationOp other) : this()
		{
			this.configId_ = other.configId_;
			this.gridIndex_ = other.gridIndex_;
			this.grids_ = other.grids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D69F RID: 54943 RVA: 0x001F9499 File Offset: 0x001F7699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTeleportByLocationOp Clone()
		{
			return new MapTeleportByLocationOp(this);
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x0600D6A0 RID: 54944 RVA: 0x001F94A1 File Offset: 0x001F76A1
		// (set) Token: 0x0600D6A1 RID: 54945 RVA: 0x001F94A9 File Offset: 0x001F76A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x0600D6A2 RID: 54946 RVA: 0x001F94B2 File Offset: 0x001F76B2
		// (set) Token: 0x0600D6A3 RID: 54947 RVA: 0x001F94BA File Offset: 0x001F76BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GridIndex
		{
			get
			{
				return this.gridIndex_;
			}
			set
			{
				this.gridIndex_ = value;
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x0600D6A4 RID: 54948 RVA: 0x001F94C3 File Offset: 0x001F76C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Grids
		{
			get
			{
				return this.grids_;
			}
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x001F94CB File Offset: 0x001F76CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTeleportByLocationOp);
		}

		// Token: 0x0600D6A6 RID: 54950 RVA: 0x001F94DC File Offset: 0x001F76DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTeleportByLocationOp other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.GridIndex == other.GridIndex && this.grids_.Equals(other.grids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6A7 RID: 54951 RVA: 0x001F953C File Offset: 0x001F773C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.GridIndex != 0)
			{
				num ^= this.GridIndex.GetHashCode();
			}
			num ^= this.grids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x001F95A2 File Offset: 0x001F77A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x001F95AF File Offset: 0x001F77AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6AA RID: 54954 RVA: 0x001F95B8 File Offset: 0x001F77B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.GridIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GridIndex);
			}
			this.grids_.WriteTo(ref output, MapTeleportByLocationOp._repeated_grids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6AB RID: 54955 RVA: 0x001F9624 File Offset: 0x001F7824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.GridIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GridIndex);
			}
			num += this.grids_.CalculateSize(MapTeleportByLocationOp._repeated_grids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D6AC RID: 54956 RVA: 0x001F9690 File Offset: 0x001F7890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapTeleportByLocationOp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.GridIndex != 0)
			{
				this.GridIndex = other.GridIndex;
			}
			this.grids_.Add(other.grids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6AD RID: 54957 RVA: 0x001F96F1 File Offset: 0x001F78F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6AE RID: 54958 RVA: 0x001F96FC File Offset: 0x001F78FC
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
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.GridIndex = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.grids_.AddEntriesFrom(ref input, MapTeleportByLocationOp._repeated_grids_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A07 RID: 23047
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A08 RID: 23048
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04005A09 RID: 23049
		private int configId_;

		// Token: 0x04005A0A RID: 23050
		public const int GridIndexFieldNumber = 2;

		// Token: 0x04005A0B RID: 23051
		private int gridIndex_;

		// Token: 0x04005A0C RID: 23052
		public const int GridsFieldNumber = 3;

		// Token: 0x04005A0D RID: 23053
		private static readonly FieldCodec<int> _repeated_grids_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005A0E RID: 23054
		private readonly RepeatedField<int> grids_ = new RepeatedField<int>();
	}
}
