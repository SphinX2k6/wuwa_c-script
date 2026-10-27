using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001308 RID: 4872
	[NetMessage(EMessageId.SyncPlayerLocationNotify)]
	public sealed class SyncPlayerLocationNotify : IMessage<SyncPlayerLocationNotify>, IMessage, IEquatable<SyncPlayerLocationNotify>, IDeepCloneable<SyncPlayerLocationNotify>, IBufferMessage
	{
		// Token: 0x06019E56 RID: 106070 RVA: 0x003C33C7 File Offset: 0x003C15C7
		[NullableContext(1)]
		public static SyncPlayerLocationNotify Create()
		{
			return new SyncPlayerLocationNotify();
		}

		// Token: 0x17005753 RID: 22355
		// (get) Token: 0x06019E57 RID: 106071 RVA: 0x003C33CE File Offset: 0x003C15CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005754 RID: 22356
		// (get) Token: 0x06019E58 RID: 106072 RVA: 0x003C33D1 File Offset: 0x003C15D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncPlayerLocationNotify.Descriptor;
			}
		}

		// Token: 0x06019E59 RID: 106073 RVA: 0x003C33D8 File Offset: 0x003C15D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncPlayerLocationNotify()
		{
		}

		// Token: 0x06019E5A RID: 106074 RVA: 0x003C33EB File Offset: 0x003C15EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncPlayerLocationNotify(SyncPlayerLocationNotify other) : this()
		{
			this.locationList_ = other.locationList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019E5B RID: 106075 RVA: 0x003C3415 File Offset: 0x003C1615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncPlayerLocationNotify Clone()
		{
			return new SyncPlayerLocationNotify(this);
		}

		// Token: 0x17005755 RID: 22357
		// (get) Token: 0x06019E5C RID: 106076 RVA: 0x003C341D File Offset: 0x003C161D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerLocation> LocationList
		{
			get
			{
				return this.locationList_;
			}
		}

		// Token: 0x06019E5D RID: 106077 RVA: 0x003C3425 File Offset: 0x003C1625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncPlayerLocationNotify);
		}

		// Token: 0x06019E5E RID: 106078 RVA: 0x003C3433 File Offset: 0x003C1633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncPlayerLocationNotify other)
		{
			return other != null && (other == this || (this.locationList_.Equals(other.locationList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019E5F RID: 106079 RVA: 0x003C3468 File Offset: 0x003C1668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.locationList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019E60 RID: 106080 RVA: 0x003C349C File Offset: 0x003C169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019E61 RID: 106081 RVA: 0x003C34A9 File Offset: 0x003C16A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019E62 RID: 106082 RVA: 0x003C34B2 File Offset: 0x003C16B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.locationList_.WriteTo(ref output, SyncPlayerLocationNotify._repeated_locationList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019E63 RID: 106083 RVA: 0x003C34DC File Offset: 0x003C16DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.locationList_.CalculateSize(SyncPlayerLocationNotify._repeated_locationList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019E64 RID: 106084 RVA: 0x003C3515 File Offset: 0x003C1715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncPlayerLocationNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.locationList_.Add(other.locationList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019E65 RID: 106085 RVA: 0x003C3543 File Offset: 0x003C1743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019E66 RID: 106086 RVA: 0x003C354C File Offset: 0x003C174C
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
					this.locationList_.AddEntriesFrom(ref input, SyncPlayerLocationNotify._repeated_locationList_codec);
				}
			}
		}

		// Token: 0x04009761 RID: 38753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009762 RID: 38754
		public const int LocationListFieldNumber = 4;

		// Token: 0x04009763 RID: 38755
		private static readonly FieldCodec<PlayerLocation> _repeated_locationList_codec = FieldCodec.ForMessage<PlayerLocation>(34U, PlayerLocation.Parser);

		// Token: 0x04009764 RID: 38756
		private readonly RepeatedField<PlayerLocation> locationList_ = new RepeatedField<PlayerLocation>();
	}
}
