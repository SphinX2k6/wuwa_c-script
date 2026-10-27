using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200118E RID: 4494
	[NetMessage(EMessageId.SceneSubLevelsChangedNotify)]
	public sealed class SceneSubLevelsChangedNotify : IMessage<SceneSubLevelsChangedNotify>, IMessage, IEquatable<SceneSubLevelsChangedNotify>, IDeepCloneable<SceneSubLevelsChangedNotify>, IBufferMessage
	{
		// Token: 0x06017F40 RID: 98112 RVA: 0x0037A911 File Offset: 0x00378B11
		[NullableContext(1)]
		public static SceneSubLevelsChangedNotify Create()
		{
			return new SceneSubLevelsChangedNotify();
		}

		// Token: 0x1700507D RID: 20605
		// (get) Token: 0x06017F41 RID: 98113 RVA: 0x0037A918 File Offset: 0x00378B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700507E RID: 20606
		// (get) Token: 0x06017F42 RID: 98114 RVA: 0x0037A91B File Offset: 0x00378B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSubLevelsChangedNotify.Descriptor;
			}
		}

		// Token: 0x06017F43 RID: 98115 RVA: 0x0037A922 File Offset: 0x00378B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsChangedNotify()
		{
		}

		// Token: 0x06017F44 RID: 98116 RVA: 0x0037A94C File Offset: 0x00378B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsChangedNotify(SceneSubLevelsChangedNotify other) : this()
		{
			this.newLoaded_ = other.newLoaded_.Clone();
			this.newUnloaded_ = other.newUnloaded_.Clone();
			this.teleportEntityId_ = other.teleportEntityId_;
			this.hideSubLevels_ = other.hideSubLevels_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017F45 RID: 98117 RVA: 0x0037A9AF File Offset: 0x00378BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsChangedNotify Clone()
		{
			return new SceneSubLevelsChangedNotify(this);
		}

		// Token: 0x1700507F RID: 20607
		// (get) Token: 0x06017F46 RID: 98118 RVA: 0x0037A9B7 File Offset: 0x00378BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> NewLoaded
		{
			get
			{
				return this.newLoaded_;
			}
		}

		// Token: 0x17005080 RID: 20608
		// (get) Token: 0x06017F47 RID: 98119 RVA: 0x0037A9BF File Offset: 0x00378BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> NewUnloaded
		{
			get
			{
				return this.newUnloaded_;
			}
		}

		// Token: 0x17005081 RID: 20609
		// (get) Token: 0x06017F48 RID: 98120 RVA: 0x0037A9C7 File Offset: 0x00378BC7
		// (set) Token: 0x06017F49 RID: 98121 RVA: 0x0037A9CF File Offset: 0x00378BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TeleportEntityId
		{
			get
			{
				return this.teleportEntityId_;
			}
			set
			{
				this.teleportEntityId_ = value;
			}
		}

		// Token: 0x17005082 RID: 20610
		// (get) Token: 0x06017F4A RID: 98122 RVA: 0x0037A9D8 File Offset: 0x00378BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HideSubLevels
		{
			get
			{
				return this.hideSubLevels_;
			}
		}

		// Token: 0x06017F4B RID: 98123 RVA: 0x0037A9E0 File Offset: 0x00378BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSubLevelsChangedNotify);
		}

		// Token: 0x06017F4C RID: 98124 RVA: 0x0037A9F0 File Offset: 0x00378BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSubLevelsChangedNotify other)
		{
			return other != null && (other == this || (this.newLoaded_.Equals(other.newLoaded_) && this.newUnloaded_.Equals(other.newUnloaded_) && this.TeleportEntityId == other.TeleportEntityId && this.hideSubLevels_.Equals(other.hideSubLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017F4D RID: 98125 RVA: 0x0037AA68 File Offset: 0x00378C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.newLoaded_.GetHashCode();
			num ^= this.newUnloaded_.GetHashCode();
			if (this.TeleportEntityId != 0)
			{
				num ^= this.TeleportEntityId.GetHashCode();
			}
			num ^= this.hideSubLevels_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017F4E RID: 98126 RVA: 0x0037AAD1 File Offset: 0x00378CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017F4F RID: 98127 RVA: 0x0037AADE File Offset: 0x00378CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017F50 RID: 98128 RVA: 0x0037AAE8 File Offset: 0x00378CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hideSubLevels_.WriteTo(ref output, SceneSubLevelsChangedNotify._repeated_hideSubLevels_codec);
			this.newUnloaded_.WriteTo(ref output, SceneSubLevelsChangedNotify._repeated_newUnloaded_codec);
			this.newLoaded_.WriteTo(ref output, SceneSubLevelsChangedNotify._repeated_newLoaded_codec);
			if (this.TeleportEntityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.TeleportEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017F51 RID: 98129 RVA: 0x0037AB58 File Offset: 0x00378D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.newLoaded_.CalculateSize(SceneSubLevelsChangedNotify._repeated_newLoaded_codec);
			num += this.newUnloaded_.CalculateSize(SceneSubLevelsChangedNotify._repeated_newUnloaded_codec);
			if (this.TeleportEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TeleportEntityId);
			}
			num += this.hideSubLevels_.CalculateSize(SceneSubLevelsChangedNotify._repeated_hideSubLevels_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017F52 RID: 98130 RVA: 0x0037ABD0 File Offset: 0x00378DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneSubLevelsChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.newLoaded_.Add(other.newLoaded_);
			this.newUnloaded_.Add(other.newUnloaded_);
			if (other.TeleportEntityId != 0)
			{
				this.TeleportEntityId = other.TeleportEntityId;
			}
			this.hideSubLevels_.Add(other.hideSubLevels_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017F53 RID: 98131 RVA: 0x0037AC3F File Offset: 0x00378E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017F54 RID: 98132 RVA: 0x0037AC48 File Offset: 0x00378E48
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
				if (num <= 66U)
				{
					if (num == 42U)
					{
						this.hideSubLevels_.AddEntriesFrom(ref input, SceneSubLevelsChangedNotify._repeated_hideSubLevels_codec);
						continue;
					}
					if (num == 66U)
					{
						this.newUnloaded_.AddEntriesFrom(ref input, SceneSubLevelsChangedNotify._repeated_newUnloaded_codec);
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						this.newLoaded_.AddEntriesFrom(ref input, SceneSubLevelsChangedNotify._repeated_newLoaded_codec);
						continue;
					}
					if (num == 112U)
					{
						this.TeleportEntityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008DE5 RID: 36325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DE6 RID: 36326
		public const int NewLoadedFieldNumber = 12;

		// Token: 0x04008DE7 RID: 36327
		private static readonly FieldCodec<string> _repeated_newLoaded_codec = FieldCodec.ForString(98U);

		// Token: 0x04008DE8 RID: 36328
		private readonly RepeatedField<string> newLoaded_ = new RepeatedField<string>();

		// Token: 0x04008DE9 RID: 36329
		public const int NewUnloadedFieldNumber = 8;

		// Token: 0x04008DEA RID: 36330
		private static readonly FieldCodec<string> _repeated_newUnloaded_codec = FieldCodec.ForString(66U);

		// Token: 0x04008DEB RID: 36331
		private readonly RepeatedField<string> newUnloaded_ = new RepeatedField<string>();

		// Token: 0x04008DEC RID: 36332
		public const int TeleportEntityIdFieldNumber = 14;

		// Token: 0x04008DED RID: 36333
		private int teleportEntityId_;

		// Token: 0x04008DEE RID: 36334
		public const int HideSubLevelsFieldNumber = 5;

		// Token: 0x04008DEF RID: 36335
		private static readonly FieldCodec<string> _repeated_hideSubLevels_codec = FieldCodec.ForString(42U);

		// Token: 0x04008DF0 RID: 36336
		private readonly RepeatedField<string> hideSubLevels_ = new RepeatedField<string>();
	}
}
