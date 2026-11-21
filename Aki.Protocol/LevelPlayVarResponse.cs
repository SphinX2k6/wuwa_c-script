using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000901 RID: 2305
	[NetMessage(EMessageId.LevelPlayVarResponse)]
	public sealed class LevelPlayVarResponse : IMessage<LevelPlayVarResponse>, IMessage, IEquatable<LevelPlayVarResponse>, IDeepCloneable<LevelPlayVarResponse>, IBufferMessage
	{
		// Token: 0x0600CBDA RID: 52186 RVA: 0x001E11F8 File Offset: 0x001DF3F8
		[NullableContext(1)]
		public static LevelPlayVarResponse Create()
		{
			return new LevelPlayVarResponse();
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600CBDB RID: 52187 RVA: 0x001E11FF File Offset: 0x001DF3FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x0600CBDC RID: 52188 RVA: 0x001E1202 File Offset: 0x001DF402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayVarResponse.Descriptor;
			}
		}

		// Token: 0x0600CBDD RID: 52189 RVA: 0x001E1209 File Offset: 0x001DF409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarResponse()
		{
		}

		// Token: 0x0600CBDE RID: 52190 RVA: 0x001E121C File Offset: 0x001DF41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarResponse(LevelPlayVarResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.vars_ = other.vars_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CBDF RID: 52191 RVA: 0x001E1252 File Offset: 0x001DF452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarResponse Clone()
		{
			return new LevelPlayVarResponse(this);
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600CBE0 RID: 52192 RVA: 0x001E125A File Offset: 0x001DF45A
		// (set) Token: 0x0600CBE1 RID: 52193 RVA: 0x001E1262 File Offset: 0x001DF462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x0600CBE2 RID: 52194 RVA: 0x001E126B File Offset: 0x001DF46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, VarDefinePb> Vars
		{
			get
			{
				return this.vars_;
			}
		}

		// Token: 0x0600CBE3 RID: 52195 RVA: 0x001E1273 File Offset: 0x001DF473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayVarResponse);
		}

		// Token: 0x0600CBE4 RID: 52196 RVA: 0x001E1284 File Offset: 0x001DF484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayVarResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Vars.Equals(other.Vars) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CBE5 RID: 52197 RVA: 0x001E12D4 File Offset: 0x001DF4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.Vars.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CBE6 RID: 52198 RVA: 0x001E1327 File Offset: 0x001DF527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CBE7 RID: 52199 RVA: 0x001E1334 File Offset: 0x001DF534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CBE8 RID: 52200 RVA: 0x001E1340 File Offset: 0x001DF540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.vars_.WriteTo(ref output, LevelPlayVarResponse._map_vars_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CBE9 RID: 52201 RVA: 0x001E1390 File Offset: 0x001DF590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.vars_.CalculateSize(LevelPlayVarResponse._map_vars_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CBEA RID: 52202 RVA: 0x001E13E4 File Offset: 0x001DF5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayVarResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.vars_.MergeFrom(other.vars_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CBEB RID: 52203 RVA: 0x001E1431 File Offset: 0x001DF631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CBEC RID: 52204 RVA: 0x001E143C File Offset: 0x001DF63C
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
				if (num != 8U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.vars_.AddEntriesFrom(ref input, LevelPlayVarResponse._map_vars_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040056DA RID: 22234
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056DB RID: 22235
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040056DC RID: 22236
		private ErrorCode errorCode_;

		// Token: 0x040056DD RID: 22237
		public const int VarsFieldNumber = 14;

		// Token: 0x040056DE RID: 22238
		private static readonly MapField<string, VarDefinePb>.Codec _map_vars_codec = new MapField<string, VarDefinePb>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForMessage<VarDefinePb>(18U, VarDefinePb.Parser), 114U);

		// Token: 0x040056DF RID: 22239
		private readonly MapField<string, VarDefinePb> vars_ = new MapField<string, VarDefinePb>();
	}
}
