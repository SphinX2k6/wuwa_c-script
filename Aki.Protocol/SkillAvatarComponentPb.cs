using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001271 RID: 4721
	public sealed class SkillAvatarComponentPb : IMessage<SkillAvatarComponentPb>, IMessage, IEquatable<SkillAvatarComponentPb>, IDeepCloneable<SkillAvatarComponentPb>, IBufferMessage
	{
		// Token: 0x06019344 RID: 103236 RVA: 0x003AD190 File Offset: 0x003AB390
		[NullableContext(1)]
		public static SkillAvatarComponentPb Create()
		{
			return new SkillAvatarComponentPb();
		}

		// Token: 0x17005538 RID: 21816
		// (get) Token: 0x06019345 RID: 103237 RVA: 0x003AD197 File Offset: 0x003AB397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005539 RID: 21817
		// (get) Token: 0x06019346 RID: 103238 RVA: 0x003AD19A File Offset: 0x003AB39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillAvatarComponentPb.Descriptor;
			}
		}

		// Token: 0x06019347 RID: 103239 RVA: 0x003AD1A1 File Offset: 0x003AB3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillAvatarComponentPb()
		{
		}

		// Token: 0x06019348 RID: 103240 RVA: 0x003AD1BF File Offset: 0x003AB3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillAvatarComponentPb(SkillAvatarComponentPb other) : this()
		{
			this.avatarIds_ = other.avatarIds_.Clone();
			this.avatarEntityIds_ = other.avatarEntityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019349 RID: 103241 RVA: 0x003AD1FA File Offset: 0x003AB3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillAvatarComponentPb Clone()
		{
			return new SkillAvatarComponentPb(this);
		}

		// Token: 0x1700553A RID: 21818
		// (get) Token: 0x0601934A RID: 103242 RVA: 0x003AD202 File Offset: 0x003AB402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AvatarIds
		{
			get
			{
				return this.avatarIds_;
			}
		}

		// Token: 0x1700553B RID: 21819
		// (get) Token: 0x0601934B RID: 103243 RVA: 0x003AD20A File Offset: 0x003AB40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AvatarEntityIds
		{
			get
			{
				return this.avatarEntityIds_;
			}
		}

		// Token: 0x0601934C RID: 103244 RVA: 0x003AD212 File Offset: 0x003AB412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillAvatarComponentPb);
		}

		// Token: 0x0601934D RID: 103245 RVA: 0x003AD220 File Offset: 0x003AB420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillAvatarComponentPb other)
		{
			return other != null && (other == this || (this.avatarIds_.Equals(other.avatarIds_) && this.avatarEntityIds_.Equals(other.avatarEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601934E RID: 103246 RVA: 0x003AD274 File Offset: 0x003AB474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avatarIds_.GetHashCode();
			num ^= this.avatarEntityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601934F RID: 103247 RVA: 0x003AD2B6 File Offset: 0x003AB4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019350 RID: 103248 RVA: 0x003AD2C3 File Offset: 0x003AB4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019351 RID: 103249 RVA: 0x003AD2CC File Offset: 0x003AB4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarIds_.WriteTo(ref output, SkillAvatarComponentPb._repeated_avatarIds_codec);
			this.avatarEntityIds_.WriteTo(ref output, SkillAvatarComponentPb._repeated_avatarEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019352 RID: 103250 RVA: 0x003AD304 File Offset: 0x003AB504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avatarIds_.CalculateSize(SkillAvatarComponentPb._repeated_avatarIds_codec);
			num += this.avatarEntityIds_.CalculateSize(SkillAvatarComponentPb._repeated_avatarEntityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019353 RID: 103251 RVA: 0x003AD350 File Offset: 0x003AB550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillAvatarComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.avatarIds_.Add(other.avatarIds_);
			this.avatarEntityIds_.Add(other.avatarEntityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019354 RID: 103252 RVA: 0x003AD38F File Offset: 0x003AB58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019355 RID: 103253 RVA: 0x003AD398 File Offset: 0x003AB598
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.avatarIds_.AddEntriesFrom(ref input, SkillAvatarComponentPb._repeated_avatarIds_codec);
						continue;
					}
				}
				else if (num == 16U || num == 18U)
				{
					this.avatarEntityIds_.AddEntriesFrom(ref input, SkillAvatarComponentPb._repeated_avatarEntityIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009531 RID: 38193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009532 RID: 38194
		public const int AvatarIdsFieldNumber = 1;

		// Token: 0x04009533 RID: 38195
		private static readonly FieldCodec<int> _repeated_avatarIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009534 RID: 38196
		private readonly RepeatedField<int> avatarIds_ = new RepeatedField<int>();

		// Token: 0x04009535 RID: 38197
		public const int AvatarEntityIdsFieldNumber = 2;

		// Token: 0x04009536 RID: 38198
		private static readonly FieldCodec<long> _repeated_avatarEntityIds_codec = FieldCodec.ForInt64(18U);

		// Token: 0x04009537 RID: 38199
		private readonly RepeatedField<long> avatarEntityIds_ = new RepeatedField<long>();
	}
}
