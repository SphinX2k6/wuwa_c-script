using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D75 RID: 3445
	[NetMessage(EMessageId.PlacementInfoChangeNotify)]
	public sealed class PlacementInfoChangeNotify : IMessage<PlacementInfoChangeNotify>, IMessage, IEquatable<PlacementInfoChangeNotify>, IDeepCloneable<PlacementInfoChangeNotify>, IBufferMessage
	{
		// Token: 0x06012928 RID: 76072 RVA: 0x002B58C7 File Offset: 0x002B3AC7
		[NullableContext(1)]
		public static PlacementInfoChangeNotify Create()
		{
			return new PlacementInfoChangeNotify();
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x06012929 RID: 76073 RVA: 0x002B58CE File Offset: 0x002B3ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0601292A RID: 76074 RVA: 0x002B58D1 File Offset: 0x002B3AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlacementInfoChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601292B RID: 76075 RVA: 0x002B58D8 File Offset: 0x002B3AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeNotify()
		{
		}

		// Token: 0x0601292C RID: 76076 RVA: 0x002B58EB File Offset: 0x002B3AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeNotify(PlacementInfoChangeNotify other) : this()
		{
			this.changedList_ = other.changedList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601292D RID: 76077 RVA: 0x002B5915 File Offset: 0x002B3B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlacementInfoChangeNotify Clone()
		{
			return new PlacementInfoChangeNotify(this);
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x0601292E RID: 76078 RVA: 0x002B591D File Offset: 0x002B3B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlacementInfoChangeInfo> ChangedList
		{
			get
			{
				return this.changedList_;
			}
		}

		// Token: 0x0601292F RID: 76079 RVA: 0x002B5925 File Offset: 0x002B3B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlacementInfoChangeNotify);
		}

		// Token: 0x06012930 RID: 76080 RVA: 0x002B5933 File Offset: 0x002B3B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlacementInfoChangeNotify other)
		{
			return other != null && (other == this || (this.changedList_.Equals(other.changedList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012931 RID: 76081 RVA: 0x002B5968 File Offset: 0x002B3B68
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

		// Token: 0x06012932 RID: 76082 RVA: 0x002B599C File Offset: 0x002B3B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012933 RID: 76083 RVA: 0x002B59A9 File Offset: 0x002B3BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012934 RID: 76084 RVA: 0x002B59B2 File Offset: 0x002B3BB2
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

		// Token: 0x06012935 RID: 76085 RVA: 0x002B59DC File Offset: 0x002B3BDC
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

		// Token: 0x06012936 RID: 76086 RVA: 0x002B5A15 File Offset: 0x002B3C15
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

		// Token: 0x06012937 RID: 76087 RVA: 0x002B5A43 File Offset: 0x002B3C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012938 RID: 76088 RVA: 0x002B5A4C File Offset: 0x002B3C4C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.changedList_.AddEntriesFrom(ref input, PlacementInfoChangeNotify._repeated_changedList_codec);
				}
			}
		}

		// Token: 0x04007352 RID: 29522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007353 RID: 29523
		public const int ChangedListFieldNumber = 4;

		// Token: 0x04007354 RID: 29524
		private static readonly FieldCodec<PlacementInfoChangeInfo> _repeated_changedList_codec = FieldCodec.ForMessage<PlacementInfoChangeInfo>(34U, PlacementInfoChangeInfo.Parser);

		// Token: 0x04007355 RID: 29525
		private readonly RepeatedField<PlacementInfoChangeInfo> changedList_ = new RepeatedField<PlacementInfoChangeInfo>();
	}
}
