using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000047 RID: 71
	[NetMessage(EMessageId.AbyssRoleSelectUpdateNotify)]
	public sealed class AbyssRoleSelectUpdateNotify : IMessage<AbyssRoleSelectUpdateNotify>, IMessage, IEquatable<AbyssRoleSelectUpdateNotify>, IDeepCloneable<AbyssRoleSelectUpdateNotify>, IBufferMessage
	{
		// Token: 0x06001449 RID: 5193 RVA: 0x000367D9 File Offset: 0x000349D9
		[NullableContext(1)]
		public static AbyssRoleSelectUpdateNotify Create()
		{
			return new AbyssRoleSelectUpdateNotify();
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x000367E0 File Offset: 0x000349E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x000367E3 File Offset: 0x000349E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleSelectUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000367EA File Offset: 0x000349EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectUpdateNotify()
		{
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000367FD File Offset: 0x000349FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectUpdateNotify(AbyssRoleSelectUpdateNotify other) : this()
		{
			this.playerInfos_ = other.playerInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00036827 File Offset: 0x00034A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectUpdateNotify Clone()
		{
			return new AbyssRoleSelectUpdateNotify(this);
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x0003682F File Offset: 0x00034A2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRoleSelectInfo> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00036837 File Offset: 0x00034A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleSelectUpdateNotify);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00036845 File Offset: 0x00034A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleSelectUpdateNotify other)
		{
			return other != null && (other == this || (this.playerInfos_.Equals(other.playerInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00036878 File Offset: 0x00034A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x000368AC File Offset: 0x00034AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x000368B9 File Offset: 0x00034AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x000368C2 File Offset: 0x00034AC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerInfos_.WriteTo(ref output, AbyssRoleSelectUpdateNotify._repeated_playerInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x000368EC File Offset: 0x00034AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerInfos_.CalculateSize(AbyssRoleSelectUpdateNotify._repeated_playerInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00036925 File Offset: 0x00034B25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRoleSelectUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerInfos_.Add(other.playerInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00036953 File Offset: 0x00034B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0003695C File Offset: 0x00034B5C
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerInfos_.AddEntriesFrom(ref input, AbyssRoleSelectUpdateNotify._repeated_playerInfos_codec);
				}
			}
		}

		// Token: 0x04002099 RID: 8345
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400209A RID: 8346
		public const int PlayerInfosFieldNumber = 9;

		// Token: 0x0400209B RID: 8347
		private static readonly FieldCodec<AbyssRoleSelectInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<AbyssRoleSelectInfo>(74U, AbyssRoleSelectInfo.Parser);

		// Token: 0x0400209C RID: 8348
		private readonly RepeatedField<AbyssRoleSelectInfo> playerInfos_ = new RepeatedField<AbyssRoleSelectInfo>();
	}
}
