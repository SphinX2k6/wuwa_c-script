using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D65 RID: 3429
	[NetMessage(EMessageId.PlacementInfoChangeNotify)]
	public sealed class PlacementInfoChangeNotify : IMessage<PlacementInfoChangeNotify>, IMessage, IEquatable<PlacementInfoChangeNotify>, IDeepCloneable<PlacementInfoChangeNotify>, IBufferMessage
	{
		// Token: 0x0601282C RID: 75820 RVA: 0x002B3CAB File Offset: 0x002B1EAB
		[NullableContext(1)]
		public static PlacementInfoChangeNotify Create()
		{
			return new PlacementInfoChangeNotify();
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0601282D RID: 75821 RVA: 0x002B3CB2 File Offset: 0x002B1EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0601282E RID: 75822 RVA: 0x002B3CB5 File Offset: 0x002B1EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlacementInfoChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601282F RID: 75823 RVA: 0x002B3CBC File Offset: 0x002B1EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeNotify()
		{
		}

		// Token: 0x06012830 RID: 75824 RVA: 0x002B3CCF File Offset: 0x002B1ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeNotify(PlacementInfoChangeNotify other) : this()
		{
			this.changedList_ = other.changedList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012831 RID: 75825 RVA: 0x002B3CF9 File Offset: 0x002B1EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeNotify Clone()
		{
			return new PlacementInfoChangeNotify(this);
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x06012832 RID: 75826 RVA: 0x002B3D01 File Offset: 0x002B1F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlacementInfoChangeInfo> ChangedList
		{
			get
			{
				return this.changedList_;
			}
		}

		// Token: 0x06012833 RID: 75827 RVA: 0x002B3D09 File Offset: 0x002B1F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlacementInfoChangeNotify);
		}

		// Token: 0x06012834 RID: 75828 RVA: 0x002B3D17 File Offset: 0x002B1F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlacementInfoChangeNotify other)
		{
			return other != null && (other == this || (this.changedList_.Equals(other.changedList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012835 RID: 75829 RVA: 0x002B3D4C File Offset: 0x002B1F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.changedList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012836 RID: 75830 RVA: 0x002B3D80 File Offset: 0x002B1F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012837 RID: 75831 RVA: 0x002B3D8D File Offset: 0x002B1F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012838 RID: 75832 RVA: 0x002B3D96 File Offset: 0x002B1F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.changedList_.WriteTo(ref output, PlacementInfoChangeNotify._repeated_changedList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012839 RID: 75833 RVA: 0x002B3DC0 File Offset: 0x002B1FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.changedList_.CalculateSize(PlacementInfoChangeNotify._repeated_changedList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601283A RID: 75834 RVA: 0x002B3DF9 File Offset: 0x002B1FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlacementInfoChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.changedList_.Add(other.changedList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601283B RID: 75835 RVA: 0x002B3E27 File Offset: 0x002B2027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601283C RID: 75836 RVA: 0x002B3E30 File Offset: 0x002B2030
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.changedList_.AddEntriesFrom(ref input, PlacementInfoChangeNotify._repeated_changedList_codec);
				}
			}
		}

		// Token: 0x0400736A RID: 29546
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400736B RID: 29547
		public const int ChangedListFieldNumber = 13;

		// Token: 0x0400736C RID: 29548
		private static readonly FieldCodec<PlacementInfoChangeInfo> _repeated_changedList_codec = FieldCodec.ForMessage<PlacementInfoChangeInfo>(106U, PlacementInfoChangeInfo.Parser);

		// Token: 0x0400736D RID: 29549
		private readonly RepeatedField<PlacementInfoChangeInfo> changedList_ = new RepeatedField<PlacementInfoChangeInfo>();
	}
}
