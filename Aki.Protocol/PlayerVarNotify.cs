using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB8 RID: 3512
	[NetMessage(EMessageId.PlayerVarNotify)]
	public sealed class PlayerVarNotify : IMessage<PlayerVarNotify>, IMessage, IEquatable<PlayerVarNotify>, IDeepCloneable<PlayerVarNotify>, IBufferMessage
	{
		// Token: 0x06012EC3 RID: 77507 RVA: 0x002C2B36 File Offset: 0x002C0D36
		[NullableContext(1)]
		public static PlayerVarNotify Create()
		{
			return new PlayerVarNotify();
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x06012EC4 RID: 77508 RVA: 0x002C2B3D File Offset: 0x002C0D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x06012EC5 RID: 77509 RVA: 0x002C2B40 File Offset: 0x002C0D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVarNotify.Descriptor;
			}
		}

		// Token: 0x06012EC6 RID: 77510 RVA: 0x002C2B47 File Offset: 0x002C0D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVarNotify()
		{
		}

		// Token: 0x06012EC7 RID: 77511 RVA: 0x002C2B5A File Offset: 0x002C0D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVarNotify(PlayerVarNotify other) : this()
		{
			this.varInfos_ = other.varInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EC8 RID: 77512 RVA: 0x002C2B84 File Offset: 0x002C0D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVarNotify Clone()
		{
			return new PlayerVarNotify(this);
		}

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x06012EC9 RID: 77513 RVA: 0x002C2B8C File Offset: 0x002C0D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, VarDefinePb> VarInfos
		{
			get
			{
				return this.varInfos_;
			}
		}

		// Token: 0x06012ECA RID: 77514 RVA: 0x002C2B94 File Offset: 0x002C0D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVarNotify);
		}

		// Token: 0x06012ECB RID: 77515 RVA: 0x002C2BA2 File Offset: 0x002C0DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVarNotify other)
		{
			return other != null && (other == this || (this.VarInfos.Equals(other.VarInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012ECC RID: 77516 RVA: 0x002C2BD8 File Offset: 0x002C0DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.VarInfos.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012ECD RID: 77517 RVA: 0x002C2C0C File Offset: 0x002C0E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012ECE RID: 77518 RVA: 0x002C2C19 File Offset: 0x002C0E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012ECF RID: 77519 RVA: 0x002C2C22 File Offset: 0x002C0E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.varInfos_.WriteTo(ref output, PlayerVarNotify._map_varInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012ED0 RID: 77520 RVA: 0x002C2C4C File Offset: 0x002C0E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.varInfos_.CalculateSize(PlayerVarNotify._map_varInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012ED1 RID: 77521 RVA: 0x002C2C85 File Offset: 0x002C0E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerVarNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.varInfos_.MergeFrom(other.varInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012ED2 RID: 77522 RVA: 0x002C2CB3 File Offset: 0x002C0EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012ED3 RID: 77523 RVA: 0x002C2CBC File Offset: 0x002C0EBC
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.varInfos_.AddEntriesFrom(ref input, PlayerVarNotify._map_varInfos_codec);
				}
			}
		}

		// Token: 0x0400751A RID: 29978
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400751B RID: 29979
		public const int VarInfosFieldNumber = 15;

		// Token: 0x0400751C RID: 29980
		private static readonly MapField<string, VarDefinePb>.Codec _map_varInfos_codec = new MapField<string, VarDefinePb>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForMessage<VarDefinePb>(18U, VarDefinePb.Parser), 122U);

		// Token: 0x0400751D RID: 29981
		private readonly MapField<string, VarDefinePb> varInfos_ = new MapField<string, VarDefinePb>();
	}
}
