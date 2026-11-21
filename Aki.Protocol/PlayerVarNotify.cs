using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA8 RID: 3496
	[NetMessage(EMessageId.PlayerVarNotify)]
	public sealed class PlayerVarNotify : IMessage<PlayerVarNotify>, IMessage, IEquatable<PlayerVarNotify>, IDeepCloneable<PlayerVarNotify>, IBufferMessage
	{
		// Token: 0x06012DC7 RID: 77255 RVA: 0x002C0F12 File Offset: 0x002BF112
		[NullableContext(1)]
		public static PlayerVarNotify Create()
		{
			return new PlayerVarNotify();
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x06012DC8 RID: 77256 RVA: 0x002C0F19 File Offset: 0x002BF119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x06012DC9 RID: 77257 RVA: 0x002C0F1C File Offset: 0x002BF11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVarNotify.Descriptor;
			}
		}

		// Token: 0x06012DCA RID: 77258 RVA: 0x002C0F23 File Offset: 0x002BF123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVarNotify()
		{
		}

		// Token: 0x06012DCB RID: 77259 RVA: 0x002C0F36 File Offset: 0x002BF136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVarNotify(PlayerVarNotify other) : this()
		{
			this.varInfos_ = other.varInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012DCC RID: 77260 RVA: 0x002C0F60 File Offset: 0x002BF160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVarNotify Clone()
		{
			return new PlayerVarNotify(this);
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x06012DCD RID: 77261 RVA: 0x002C0F68 File Offset: 0x002BF168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, VarDefinePb> VarInfos
		{
			get
			{
				return this.varInfos_;
			}
		}

		// Token: 0x06012DCE RID: 77262 RVA: 0x002C0F70 File Offset: 0x002BF170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVarNotify);
		}

		// Token: 0x06012DCF RID: 77263 RVA: 0x002C0F7E File Offset: 0x002BF17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVarNotify other)
		{
			return other != null && (other == this || (this.VarInfos.Equals(other.VarInfos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012DD0 RID: 77264 RVA: 0x002C0FB4 File Offset: 0x002BF1B4
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

		// Token: 0x06012DD1 RID: 77265 RVA: 0x002C0FE8 File Offset: 0x002BF1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012DD2 RID: 77266 RVA: 0x002C0FF5 File Offset: 0x002BF1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012DD3 RID: 77267 RVA: 0x002C0FFE File Offset: 0x002BF1FE
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

		// Token: 0x06012DD4 RID: 77268 RVA: 0x002C1028 File Offset: 0x002BF228
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

		// Token: 0x06012DD5 RID: 77269 RVA: 0x002C1061 File Offset: 0x002BF261
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

		// Token: 0x06012DD6 RID: 77270 RVA: 0x002C108F File Offset: 0x002BF28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012DD7 RID: 77271 RVA: 0x002C1098 File Offset: 0x002BF298
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.varInfos_.AddEntriesFrom(ref input, PlayerVarNotify._map_varInfos_codec);
				}
			}
		}

		// Token: 0x04007532 RID: 30002
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007533 RID: 30003
		public const int VarInfosFieldNumber = 2;

		// Token: 0x04007534 RID: 30004
		private static readonly MapField<string, VarDefinePb>.Codec _map_varInfos_codec = new MapField<string, VarDefinePb>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForMessage<VarDefinePb>(18U, VarDefinePb.Parser), 18U);

		// Token: 0x04007535 RID: 30005
		private readonly MapField<string, VarDefinePb> varInfos_ = new MapField<string, VarDefinePb>();
	}
}
