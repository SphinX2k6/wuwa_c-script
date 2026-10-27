using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B9 RID: 5049
	[NetMessage(EMessageId.TowerFloorUpdateNotify)]
	public sealed class TowerFloorUpdateNotify : IMessage<TowerFloorUpdateNotify>, IMessage, IEquatable<TowerFloorUpdateNotify>, IDeepCloneable<TowerFloorUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601AC96 RID: 109718 RVA: 0x003E270D File Offset: 0x003E090D
		[NullableContext(1)]
		public static TowerFloorUpdateNotify Create()
		{
			return new TowerFloorUpdateNotify();
		}

		// Token: 0x17005A59 RID: 23129
		// (get) Token: 0x0601AC97 RID: 109719 RVA: 0x003E2714 File Offset: 0x003E0914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A5A RID: 23130
		// (get) Token: 0x0601AC98 RID: 109720 RVA: 0x003E2717 File Offset: 0x003E0917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerFloorUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601AC99 RID: 109721 RVA: 0x003E271E File Offset: 0x003E091E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorUpdateNotify()
		{
		}

		// Token: 0x0601AC9A RID: 109722 RVA: 0x003E2731 File Offset: 0x003E0931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorUpdateNotify(TowerFloorUpdateNotify other) : this()
		{
			this.towerFloors_ = other.towerFloors_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AC9B RID: 109723 RVA: 0x003E275B File Offset: 0x003E095B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFloorUpdateNotify Clone()
		{
			return new TowerFloorUpdateNotify(this);
		}

		// Token: 0x17005A5B RID: 23131
		// (get) Token: 0x0601AC9C RID: 109724 RVA: 0x003E2763 File Offset: 0x003E0963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerFloorPb> TowerFloors
		{
			get
			{
				return this.towerFloors_;
			}
		}

		// Token: 0x0601AC9D RID: 109725 RVA: 0x003E276B File Offset: 0x003E096B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerFloorUpdateNotify);
		}

		// Token: 0x0601AC9E RID: 109726 RVA: 0x003E2779 File Offset: 0x003E0979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerFloorUpdateNotify other)
		{
			return other != null && (other == this || (this.towerFloors_.Equals(other.towerFloors_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AC9F RID: 109727 RVA: 0x003E27AC File Offset: 0x003E09AC
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

		// Token: 0x0601ACA0 RID: 109728 RVA: 0x003E27E0 File Offset: 0x003E09E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACA1 RID: 109729 RVA: 0x003E27ED File Offset: 0x003E09ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACA2 RID: 109730 RVA: 0x003E27F6 File Offset: 0x003E09F6
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

		// Token: 0x0601ACA3 RID: 109731 RVA: 0x003E2820 File Offset: 0x003E0A20
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

		// Token: 0x0601ACA4 RID: 109732 RVA: 0x003E2859 File Offset: 0x003E0A59
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

		// Token: 0x0601ACA5 RID: 109733 RVA: 0x003E2887 File Offset: 0x003E0A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACA6 RID: 109734 RVA: 0x003E2890 File Offset: 0x003E0A90
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.towerFloors_.AddEntriesFrom(ref input, TowerFloorUpdateNotify._repeated_towerFloors_codec);
				}
			}
		}

		// Token: 0x04009B87 RID: 39815
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B88 RID: 39816
		public const int TowerFloorsFieldNumber = 6;

		// Token: 0x04009B89 RID: 39817
		private static readonly FieldCodec<TowerFloorPb> _repeated_towerFloors_codec = FieldCodec.ForMessage<TowerFloorPb>(50U, TowerFloorPb.Parser);

		// Token: 0x04009B8A RID: 39818
		private readonly RepeatedField<TowerFloorPb> towerFloors_ = new RepeatedField<TowerFloorPb>();
	}
}
