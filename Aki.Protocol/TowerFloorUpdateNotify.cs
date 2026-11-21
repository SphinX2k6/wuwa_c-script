using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142C RID: 5164
	[NetMessage(EMessageId.TowerFloorUpdateNotify)]
	public sealed class TowerFloorUpdateNotify : IMessage<TowerFloorUpdateNotify>, IMessage, IEquatable<TowerFloorUpdateNotify>, IDeepCloneable<TowerFloorUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B721 RID: 112417 RVA: 0x003FD9D1 File Offset: 0x003FBBD1
		[NullableContext(1)]
		public static TowerFloorUpdateNotify Create()
		{
			return new TowerFloorUpdateNotify();
		}

		// Token: 0x17005CEE RID: 23790
		// (get) Token: 0x0601B722 RID: 112418 RVA: 0x003FD9D8 File Offset: 0x003FBBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CEF RID: 23791
		// (get) Token: 0x0601B723 RID: 112419 RVA: 0x003FD9DB File Offset: 0x003FBBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerFloorUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B724 RID: 112420 RVA: 0x003FD9E2 File Offset: 0x003FBBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorUpdateNotify()
		{
		}

		// Token: 0x0601B725 RID: 112421 RVA: 0x003FD9F5 File Offset: 0x003FBBF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorUpdateNotify(TowerFloorUpdateNotify other) : this()
		{
			this.towerFloors_ = other.towerFloors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B726 RID: 112422 RVA: 0x003FDA1F File Offset: 0x003FBC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorUpdateNotify Clone()
		{
			return new TowerFloorUpdateNotify(this);
		}

		// Token: 0x17005CF0 RID: 23792
		// (get) Token: 0x0601B727 RID: 112423 RVA: 0x003FDA27 File Offset: 0x003FBC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerFloorPb> TowerFloors
		{
			get
			{
				return this.towerFloors_;
			}
		}

		// Token: 0x0601B728 RID: 112424 RVA: 0x003FDA2F File Offset: 0x003FBC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerFloorUpdateNotify);
		}

		// Token: 0x0601B729 RID: 112425 RVA: 0x003FDA3D File Offset: 0x003FBC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerFloorUpdateNotify other)
		{
			return other != null && (other == this || (this.towerFloors_.Equals(other.towerFloors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B72A RID: 112426 RVA: 0x003FDA70 File Offset: 0x003FBC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.towerFloors_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B72B RID: 112427 RVA: 0x003FDAA4 File Offset: 0x003FBCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B72C RID: 112428 RVA: 0x003FDAB1 File Offset: 0x003FBCB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B72D RID: 112429 RVA: 0x003FDABA File Offset: 0x003FBCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.towerFloors_.WriteTo(ref output, TowerFloorUpdateNotify._repeated_towerFloors_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B72E RID: 112430 RVA: 0x003FDAE4 File Offset: 0x003FBCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.towerFloors_.CalculateSize(TowerFloorUpdateNotify._repeated_towerFloors_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B72F RID: 112431 RVA: 0x003FDB1D File Offset: 0x003FBD1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerFloorUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.towerFloors_.Add(other.towerFloors_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B730 RID: 112432 RVA: 0x003FDB4B File Offset: 0x003FBD4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B731 RID: 112433 RVA: 0x003FDB54 File Offset: 0x003FBD54
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.towerFloors_.AddEntriesFrom(ref input, TowerFloorUpdateNotify._repeated_towerFloors_codec);
				}
			}
		}

		// Token: 0x04009FCE RID: 40910
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FCF RID: 40911
		public const int TowerFloorsFieldNumber = 15;

		// Token: 0x04009FD0 RID: 40912
		private static readonly FieldCodec<TowerFloorPb> _repeated_towerFloors_codec = FieldCodec.ForMessage<TowerFloorPb>(122U, TowerFloorPb.Parser);

		// Token: 0x04009FD1 RID: 40913
		private readonly RepeatedField<TowerFloorPb> towerFloors_ = new RepeatedField<TowerFloorPb>();
	}
}
