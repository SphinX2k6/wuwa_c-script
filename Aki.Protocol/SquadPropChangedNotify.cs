using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001287 RID: 4743
	[NetMessage(EMessageId.SquadPropChangedNotify)]
	public sealed class SquadPropChangedNotify : IMessage<SquadPropChangedNotify>, IMessage, IEquatable<SquadPropChangedNotify>, IDeepCloneable<SquadPropChangedNotify>, IBufferMessage
	{
		// Token: 0x0601941D RID: 103453 RVA: 0x003AC626 File Offset: 0x003AA826
		[NullableContext(1)]
		public static SquadPropChangedNotify Create()
		{
			return new SquadPropChangedNotify();
		}

		// Token: 0x17005532 RID: 21810
		// (get) Token: 0x0601941E RID: 103454 RVA: 0x003AC62D File Offset: 0x003AA82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005533 RID: 21811
		// (get) Token: 0x0601941F RID: 103455 RVA: 0x003AC630 File Offset: 0x003AA830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SquadPropChangedNotify.Descriptor;
			}
		}

		// Token: 0x06019420 RID: 103456 RVA: 0x003AC637 File Offset: 0x003AA837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropChangedNotify()
		{
		}

		// Token: 0x06019421 RID: 103457 RVA: 0x003AC64A File Offset: 0x003AA84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropChangedNotify(SquadPropChangedNotify other) : this()
		{
			this.attributes_ = other.attributes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019422 RID: 103458 RVA: 0x003AC674 File Offset: 0x003AA874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SquadPropChangedNotify Clone()
		{
			return new SquadPropChangedNotify(this);
		}

		// Token: 0x17005534 RID: 21812
		// (get) Token: 0x06019423 RID: 103459 RVA: 0x003AC67C File Offset: 0x003AA87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GameplayAttributeData> Attributes
		{
			get
			{
				return this.attributes_;
			}
		}

		// Token: 0x06019424 RID: 103460 RVA: 0x003AC684 File Offset: 0x003AA884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SquadPropChangedNotify);
		}

		// Token: 0x06019425 RID: 103461 RVA: 0x003AC692 File Offset: 0x003AA892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SquadPropChangedNotify other)
		{
			return other != null && (other == this || (this.attributes_.Equals(other.attributes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019426 RID: 103462 RVA: 0x003AC6C8 File Offset: 0x003AA8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attributes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019427 RID: 103463 RVA: 0x003AC6FC File Offset: 0x003AA8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019428 RID: 103464 RVA: 0x003AC709 File Offset: 0x003AA909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019429 RID: 103465 RVA: 0x003AC712 File Offset: 0x003AA912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributes_.WriteTo(ref output, SquadPropChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601942A RID: 103466 RVA: 0x003AC73C File Offset: 0x003AA93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributes_.CalculateSize(SquadPropChangedNotify._repeated_attributes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601942B RID: 103467 RVA: 0x003AC775 File Offset: 0x003AA975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SquadPropChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.attributes_.Add(other.attributes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601942C RID: 103468 RVA: 0x003AC7A3 File Offset: 0x003AA9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601942D RID: 103469 RVA: 0x003AC7AC File Offset: 0x003AA9AC
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
					this.attributes_.AddEntriesFrom(ref input, SquadPropChangedNotify._repeated_attributes_codec);
				}
			}
		}

		// Token: 0x04009489 RID: 38025
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400948A RID: 38026
		public const int AttributesFieldNumber = 13;

		// Token: 0x0400948B RID: 38027
		private static readonly FieldCodec<GameplayAttributeData> _repeated_attributes_codec = FieldCodec.ForMessage<GameplayAttributeData>(106U, GameplayAttributeData.Parser);

		// Token: 0x0400948C RID: 38028
		private readonly RepeatedField<GameplayAttributeData> attributes_ = new RepeatedField<GameplayAttributeData>();
	}
}
