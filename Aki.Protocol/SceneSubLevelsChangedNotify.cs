using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011C8 RID: 4552
	[NetMessage(EMessageId.SceneSubLevelsChangedNotify)]
	public sealed class SceneSubLevelsChangedNotify : IMessage<SceneSubLevelsChangedNotify>, IMessage, IEquatable<SceneSubLevelsChangedNotify>, IDeepCloneable<SceneSubLevelsChangedNotify>, IBufferMessage
	{
		// Token: 0x060184E1 RID: 99553 RVA: 0x00389C51 File Offset: 0x00387E51
		[NullableContext(1)]
		public static SceneSubLevelsChangedNotify Create()
		{
			return new SceneSubLevelsChangedNotify();
		}

		// Token: 0x170051E9 RID: 20969
		// (get) Token: 0x060184E2 RID: 99554 RVA: 0x00389C58 File Offset: 0x00387E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051EA RID: 20970
		// (get) Token: 0x060184E3 RID: 99555 RVA: 0x00389C5B File Offset: 0x00387E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneSubLevelsChangedNotify.Descriptor;
			}
		}

		// Token: 0x060184E4 RID: 99556 RVA: 0x00389C62 File Offset: 0x00387E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsChangedNotify()
		{
		}

		// Token: 0x060184E5 RID: 99557 RVA: 0x00389C8C File Offset: 0x00387E8C
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

		// Token: 0x060184E6 RID: 99558 RVA: 0x00389CEF File Offset: 0x00387EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneSubLevelsChangedNotify Clone()
		{
			return new SceneSubLevelsChangedNotify(this);
		}

		// Token: 0x170051EB RID: 20971
		// (get) Token: 0x060184E7 RID: 99559 RVA: 0x00389CF7 File Offset: 0x00387EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> NewLoaded
		{
			get
			{
				return this.newLoaded_;
			}
		}

		// Token: 0x170051EC RID: 20972
		// (get) Token: 0x060184E8 RID: 99560 RVA: 0x00389CFF File Offset: 0x00387EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> NewUnloaded
		{
			get
			{
				return this.newUnloaded_;
			}
		}

		// Token: 0x170051ED RID: 20973
		// (get) Token: 0x060184E9 RID: 99561 RVA: 0x00389D07 File Offset: 0x00387F07
		// (set) Token: 0x060184EA RID: 99562 RVA: 0x00389D0F File Offset: 0x00387F0F
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

		// Token: 0x170051EE RID: 20974
		// (get) Token: 0x060184EB RID: 99563 RVA: 0x00389D18 File Offset: 0x00387F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> HideSubLevels
		{
			get
			{
				return this.hideSubLevels_;
			}
		}

		// Token: 0x060184EC RID: 99564 RVA: 0x00389D20 File Offset: 0x00387F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneSubLevelsChangedNotify);
		}

		// Token: 0x060184ED RID: 99565 RVA: 0x00389D30 File Offset: 0x00387F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneSubLevelsChangedNotify other)
		{
			return other != null && (other == this || (this.newLoaded_.Equals(other.newLoaded_) && this.newUnloaded_.Equals(other.newUnloaded_) && this.TeleportEntityId == other.TeleportEntityId && this.hideSubLevels_.Equals(other.hideSubLevels_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060184EE RID: 99566 RVA: 0x00389DA8 File Offset: 0x00387FA8
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

		// Token: 0x060184EF RID: 99567 RVA: 0x00389E11 File Offset: 0x00388011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060184F0 RID: 99568 RVA: 0x00389E1E File Offset: 0x0038801E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060184F1 RID: 99569 RVA: 0x00389E28 File Offset: 0x00388028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.newUnloaded_.WriteTo(ref output, SceneSubLevelsChangedNotify._repeated_newUnloaded_codec);
			this.hideSubLevels_.WriteTo(ref output, SceneSubLevelsChangedNotify._repeated_hideSubLevels_codec);
			this.newLoaded_.WriteTo(ref output, SceneSubLevelsChangedNotify._repeated_newLoaded_codec);
			if (this.TeleportEntityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TeleportEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060184F2 RID: 99570 RVA: 0x00389E98 File Offset: 0x00388098
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

		// Token: 0x060184F3 RID: 99571 RVA: 0x00389F10 File Offset: 0x00388110
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

		// Token: 0x060184F4 RID: 99572 RVA: 0x00389F7F File Offset: 0x0038817F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060184F5 RID: 99573 RVA: 0x00389F88 File Offset: 0x00388188
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
				if (num <= 50U)
				{
					if (num == 26U)
					{
						this.newUnloaded_.AddEntriesFrom(ref input, SceneSubLevelsChangedNotify._repeated_newUnloaded_codec);
						continue;
					}
					if (num == 50U)
					{
						this.hideSubLevels_.AddEntriesFrom(ref input, SceneSubLevelsChangedNotify._repeated_hideSubLevels_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.newLoaded_.AddEntriesFrom(ref input, SceneSubLevelsChangedNotify._repeated_newLoaded_codec);
						continue;
					}
					if (num == 120U)
					{
						this.TeleportEntityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009078 RID: 36984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009079 RID: 36985
		public const int NewLoadedFieldNumber = 9;

		// Token: 0x0400907A RID: 36986
		private static readonly FieldCodec<string> _repeated_newLoaded_codec = FieldCodec.ForString(74U);

		// Token: 0x0400907B RID: 36987
		private readonly RepeatedField<string> newLoaded_ = new RepeatedField<string>();

		// Token: 0x0400907C RID: 36988
		public const int NewUnloadedFieldNumber = 3;

		// Token: 0x0400907D RID: 36989
		private static readonly FieldCodec<string> _repeated_newUnloaded_codec = FieldCodec.ForString(26U);

		// Token: 0x0400907E RID: 36990
		private readonly RepeatedField<string> newUnloaded_ = new RepeatedField<string>();

		// Token: 0x0400907F RID: 36991
		public const int TeleportEntityIdFieldNumber = 15;

		// Token: 0x04009080 RID: 36992
		private int teleportEntityId_;

		// Token: 0x04009081 RID: 36993
		public const int HideSubLevelsFieldNumber = 6;

		// Token: 0x04009082 RID: 36994
		private static readonly FieldCodec<string> _repeated_hideSubLevels_codec = FieldCodec.ForString(50U);

		// Token: 0x04009083 RID: 36995
		private readonly RepeatedField<string> hideSubLevels_ = new RepeatedField<string>();
	}
}
