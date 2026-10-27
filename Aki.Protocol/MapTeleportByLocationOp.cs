using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000997 RID: 2455
	public sealed class MapTeleportByLocationOp : IMessage<MapTeleportByLocationOp>, IMessage, IEquatable<MapTeleportByLocationOp>, IDeepCloneable<MapTeleportByLocationOp>, IBufferMessage
	{
		// Token: 0x0600D7B4 RID: 55220 RVA: 0x001FB617 File Offset: 0x001F9817
		[NullableContext(1)]
		public static MapTeleportByLocationOp Create()
		{
			return new MapTeleportByLocationOp();
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x0600D7B5 RID: 55221 RVA: 0x001FB61E File Offset: 0x001F981E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x0600D7B6 RID: 55222 RVA: 0x001FB621 File Offset: 0x001F9821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapTeleportByLocationOp.Descriptor;
			}
		}

		// Token: 0x0600D7B7 RID: 55223 RVA: 0x001FB628 File Offset: 0x001F9828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTeleportByLocationOp()
		{
		}

		// Token: 0x0600D7B8 RID: 55224 RVA: 0x001FB63C File Offset: 0x001F983C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTeleportByLocationOp(MapTeleportByLocationOp other) : this()
		{
			this.configId_ = other.configId_;
			this.gridIndex_ = other.gridIndex_;
			this.grids_ = other.grids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x001FB689 File Offset: 0x001F9889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapTeleportByLocationOp Clone()
		{
			return new MapTeleportByLocationOp(this);
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x0600D7BA RID: 55226 RVA: 0x001FB691 File Offset: 0x001F9891
		// (set) Token: 0x0600D7BB RID: 55227 RVA: 0x001FB699 File Offset: 0x001F9899
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

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x0600D7BC RID: 55228 RVA: 0x001FB6A2 File Offset: 0x001F98A2
		// (set) Token: 0x0600D7BD RID: 55229 RVA: 0x001FB6AA File Offset: 0x001F98AA
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

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x0600D7BE RID: 55230 RVA: 0x001FB6B3 File Offset: 0x001F98B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Grids
		{
			get
			{
				return this.grids_;
			}
		}

		// Token: 0x0600D7BF RID: 55231 RVA: 0x001FB6BB File Offset: 0x001F98BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapTeleportByLocationOp);
		}

		// Token: 0x0600D7C0 RID: 55232 RVA: 0x001FB6CC File Offset: 0x001F98CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapTeleportByLocationOp other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.GridIndex == other.GridIndex && this.grids_.Equals(other.grids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x001FB72C File Offset: 0x001F992C
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

		// Token: 0x0600D7C2 RID: 55234 RVA: 0x001FB792 File Offset: 0x001F9992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D7C3 RID: 55235 RVA: 0x001FB79F File Offset: 0x001F999F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7C4 RID: 55236 RVA: 0x001FB7A8 File Offset: 0x001F99A8
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

		// Token: 0x0600D7C5 RID: 55237 RVA: 0x001FB814 File Offset: 0x001F9A14
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

		// Token: 0x0600D7C6 RID: 55238 RVA: 0x001FB880 File Offset: 0x001F9A80
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

		// Token: 0x0600D7C7 RID: 55239 RVA: 0x001FB8E1 File Offset: 0x001F9AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7C8 RID: 55240 RVA: 0x001FB8EC File Offset: 0x001F9AEC
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

		// Token: 0x040059FE RID: 23038
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059FF RID: 23039
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04005A00 RID: 23040
		private int configId_;

		// Token: 0x04005A01 RID: 23041
		public const int GridIndexFieldNumber = 2;

		// Token: 0x04005A02 RID: 23042
		private int gridIndex_;

		// Token: 0x04005A03 RID: 23043
		public const int GridsFieldNumber = 3;

		// Token: 0x04005A04 RID: 23044
		private static readonly FieldCodec<int> _repeated_grids_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005A05 RID: 23045
		private readonly RepeatedField<int> grids_ = new RepeatedField<int>();
	}
}
