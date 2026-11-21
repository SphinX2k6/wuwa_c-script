using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200151E RID: 5406
	[NetMessage(EMessageId.UpdateSceneGroupDataNotify)]
	public sealed class UpdateSceneGroupDataNotify : IMessage<UpdateSceneGroupDataNotify>, IMessage, IEquatable<UpdateSceneGroupDataNotify>, IDeepCloneable<UpdateSceneGroupDataNotify>, IBufferMessage
	{
		// Token: 0x0601CA3C RID: 117308 RVA: 0x004266D0 File Offset: 0x004248D0
		[NullableContext(1)]
		public static UpdateSceneGroupDataNotify Create()
		{
			return new UpdateSceneGroupDataNotify();
		}

		// Token: 0x170060DF RID: 24799
		// (get) Token: 0x0601CA3D RID: 117309 RVA: 0x004266D7 File Offset: 0x004248D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060E0 RID: 24800
		// (get) Token: 0x0601CA3E RID: 117310 RVA: 0x004266DA File Offset: 0x004248DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateSceneGroupDataNotify.Descriptor;
			}
		}

		// Token: 0x0601CA3F RID: 117311 RVA: 0x004266E1 File Offset: 0x004248E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataNotify()
		{
		}

		// Token: 0x0601CA40 RID: 117312 RVA: 0x004266F4 File Offset: 0x004248F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataNotify(UpdateSceneGroupDataNotify other) : this()
		{
			this.playerSceneGroupDataList_ = other.playerSceneGroupDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CA41 RID: 117313 RVA: 0x0042671E File Offset: 0x0042491E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateSceneGroupDataNotify Clone()
		{
			return new UpdateSceneGroupDataNotify(this);
		}

		// Token: 0x170060E1 RID: 24801
		// (get) Token: 0x0601CA42 RID: 117314 RVA: 0x00426726 File Offset: 0x00424926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerSceneGroupDataList> PlayerSceneGroupDataList
		{
			get
			{
				return this.playerSceneGroupDataList_;
			}
		}

		// Token: 0x0601CA43 RID: 117315 RVA: 0x0042672E File Offset: 0x0042492E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateSceneGroupDataNotify);
		}

		// Token: 0x0601CA44 RID: 117316 RVA: 0x0042673C File Offset: 0x0042493C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateSceneGroupDataNotify other)
		{
			return other != null && (other == this || (this.playerSceneGroupDataList_.Equals(other.playerSceneGroupDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CA45 RID: 117317 RVA: 0x00426770 File Offset: 0x00424970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerSceneGroupDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CA46 RID: 117318 RVA: 0x004267A4 File Offset: 0x004249A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CA47 RID: 117319 RVA: 0x004267B1 File Offset: 0x004249B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CA48 RID: 117320 RVA: 0x004267BA File Offset: 0x004249BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerSceneGroupDataList_.WriteTo(ref output, UpdateSceneGroupDataNotify._repeated_playerSceneGroupDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CA49 RID: 117321 RVA: 0x004267E4 File Offset: 0x004249E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerSceneGroupDataList_.CalculateSize(UpdateSceneGroupDataNotify._repeated_playerSceneGroupDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CA4A RID: 117322 RVA: 0x0042681D File Offset: 0x00424A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateSceneGroupDataNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerSceneGroupDataList_.Add(other.playerSceneGroupDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CA4B RID: 117323 RVA: 0x0042684B File Offset: 0x00424A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CA4C RID: 117324 RVA: 0x00426854 File Offset: 0x00424A54
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerSceneGroupDataList_.AddEntriesFrom(ref input, UpdateSceneGroupDataNotify._repeated_playerSceneGroupDataList_codec);
				}
			}
		}

		// Token: 0x0400A4FF RID: 42239
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A500 RID: 42240
		public const int PlayerSceneGroupDataListFieldNumber = 12;

		// Token: 0x0400A501 RID: 42241
		private static readonly FieldCodec<PlayerSceneGroupDataList> _repeated_playerSceneGroupDataList_codec = FieldCodec.ForMessage<PlayerSceneGroupDataList>(98U, Aki.Protocol.PlayerSceneGroupDataList.Parser);

		// Token: 0x0400A502 RID: 42242
		private readonly RepeatedField<PlayerSceneGroupDataList> playerSceneGroupDataList_ = new RepeatedField<PlayerSceneGroupDataList>();
	}
}
