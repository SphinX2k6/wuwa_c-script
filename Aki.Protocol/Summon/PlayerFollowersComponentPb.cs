using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Summon
{
	// Token: 0x020016F4 RID: 5876
	public sealed class PlayerFollowersComponentPb : IMessage<PlayerFollowersComponentPb>, IMessage, IEquatable<PlayerFollowersComponentPb>, IDeepCloneable<PlayerFollowersComponentPb>, IBufferMessage
	{
		// Token: 0x0601D5EC RID: 120300 RVA: 0x004401EF File Offset: 0x0043E3EF
		[NullableContext(1)]
		public static PlayerFollowersComponentPb Create()
		{
			return new PlayerFollowersComponentPb();
		}

		// Token: 0x1700635A RID: 25434
		// (get) Token: 0x0601D5ED RID: 120301 RVA: 0x004401F6 File Offset: 0x0043E3F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700635B RID: 25435
		// (get) Token: 0x0601D5EE RID: 120302 RVA: 0x004401F9 File Offset: 0x0043E3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerFollowersComponentPb.Descriptor;
			}
		}

		// Token: 0x0601D5EF RID: 120303 RVA: 0x00440200 File Offset: 0x0043E400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowersComponentPb()
		{
		}

		// Token: 0x0601D5F0 RID: 120304 RVA: 0x00440213 File Offset: 0x0043E413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowersComponentPb(PlayerFollowersComponentPb other) : this()
		{
			this.listPlayerFollowerPb_ = other.listPlayerFollowerPb_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D5F1 RID: 120305 RVA: 0x0044023D File Offset: 0x0043E43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerFollowersComponentPb Clone()
		{
			return new PlayerFollowersComponentPb(this);
		}

		// Token: 0x1700635C RID: 25436
		// (get) Token: 0x0601D5F2 RID: 120306 RVA: 0x00440245 File Offset: 0x0043E445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerFollowerPb> ListPlayerFollowerPb
		{
			get
			{
				return this.listPlayerFollowerPb_;
			}
		}

		// Token: 0x0601D5F3 RID: 120307 RVA: 0x0044024D File Offset: 0x0043E44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerFollowersComponentPb);
		}

		// Token: 0x0601D5F4 RID: 120308 RVA: 0x0044025B File Offset: 0x0043E45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerFollowersComponentPb other)
		{
			return other != null && (other == this || (this.listPlayerFollowerPb_.Equals(other.listPlayerFollowerPb_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D5F5 RID: 120309 RVA: 0x00440290 File Offset: 0x0043E490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.listPlayerFollowerPb_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D5F6 RID: 120310 RVA: 0x004402C4 File Offset: 0x0043E4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D5F7 RID: 120311 RVA: 0x004402D1 File Offset: 0x0043E4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D5F8 RID: 120312 RVA: 0x004402DA File Offset: 0x0043E4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.listPlayerFollowerPb_.WriteTo(ref output, PlayerFollowersComponentPb._repeated_listPlayerFollowerPb_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D5F9 RID: 120313 RVA: 0x00440304 File Offset: 0x0043E504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.listPlayerFollowerPb_.CalculateSize(PlayerFollowersComponentPb._repeated_listPlayerFollowerPb_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D5FA RID: 120314 RVA: 0x0044033D File Offset: 0x0043E53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerFollowersComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.listPlayerFollowerPb_.Add(other.listPlayerFollowerPb_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D5FB RID: 120315 RVA: 0x0044036B File Offset: 0x0043E56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D5FC RID: 120316 RVA: 0x00440374 File Offset: 0x0043E574
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.listPlayerFollowerPb_.AddEntriesFrom(ref input, PlayerFollowersComponentPb._repeated_listPlayerFollowerPb_codec);
				}
			}
		}

		// Token: 0x0400C703 RID: 50947
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C704 RID: 50948
		public const int ListPlayerFollowerPbFieldNumber = 1;

		// Token: 0x0400C705 RID: 50949
		private static readonly FieldCodec<PlayerFollowerPb> _repeated_listPlayerFollowerPb_codec = FieldCodec.ForMessage<PlayerFollowerPb>(10U, PlayerFollowerPb.Parser);

		// Token: 0x0400C706 RID: 50950
		private readonly RepeatedField<PlayerFollowerPb> listPlayerFollowerPb_ = new RepeatedField<PlayerFollowerPb>();
	}
}
