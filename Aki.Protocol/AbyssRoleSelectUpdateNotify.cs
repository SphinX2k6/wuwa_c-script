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
		// Token: 0x0600141E RID: 5150 RVA: 0x00036221 File Offset: 0x00034421
		[NullableContext(1)]
		public static AbyssRoleSelectUpdateNotify Create()
		{
			return new AbyssRoleSelectUpdateNotify();
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x00036228 File Offset: 0x00034428
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
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0003622B File Offset: 0x0003442B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleSelectUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00036232 File Offset: 0x00034432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectUpdateNotify()
		{
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00036245 File Offset: 0x00034445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectUpdateNotify(AbyssRoleSelectUpdateNotify other) : this()
		{
			this.playerInfos_ = other.playerInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0003626F File Offset: 0x0003446F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectUpdateNotify Clone()
		{
			return new AbyssRoleSelectUpdateNotify(this);
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x00036277 File Offset: 0x00034477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssRoleSelectInfo> PlayerInfos
		{
			get
			{
				return this.playerInfos_;
			}
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0003627F File Offset: 0x0003447F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleSelectUpdateNotify);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0003628D File Offset: 0x0003448D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleSelectUpdateNotify other)
		{
			return other != null && (other == this || (this.playerInfos_.Equals(other.playerInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000362C0 File Offset: 0x000344C0
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

		// Token: 0x06001428 RID: 5160 RVA: 0x000362F4 File Offset: 0x000344F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x00036301 File Offset: 0x00034501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0003630A File Offset: 0x0003450A
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

		// Token: 0x0600142B RID: 5163 RVA: 0x00036334 File Offset: 0x00034534
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

		// Token: 0x0600142C RID: 5164 RVA: 0x0003636D File Offset: 0x0003456D
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

		// Token: 0x0600142D RID: 5165 RVA: 0x0003639B File Offset: 0x0003459B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000363A4 File Offset: 0x000345A4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playerInfos_.AddEntriesFrom(ref input, AbyssRoleSelectUpdateNotify._repeated_playerInfos_codec);
				}
			}
		}

		// Token: 0x04002043 RID: 8259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002044 RID: 8260
		public const int PlayerInfosFieldNumber = 8;

		// Token: 0x04002045 RID: 8261
		private static readonly FieldCodec<AbyssRoleSelectInfo> _repeated_playerInfos_codec = FieldCodec.ForMessage<AbyssRoleSelectInfo>(66U, AbyssRoleSelectInfo.Parser);

		// Token: 0x04002046 RID: 8262
		private readonly RepeatedField<AbyssRoleSelectInfo> playerInfos_ = new RepeatedField<AbyssRoleSelectInfo>();
	}
}
