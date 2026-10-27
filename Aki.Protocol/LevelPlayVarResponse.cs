using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000912 RID: 2322
	[NetMessage(EMessageId.LevelPlayVarResponse)]
	public sealed class LevelPlayVarResponse : IMessage<LevelPlayVarResponse>, IMessage, IEquatable<LevelPlayVarResponse>, IDeepCloneable<LevelPlayVarResponse>, IBufferMessage
	{
		// Token: 0x0600CCF6 RID: 52470 RVA: 0x001E34CB File Offset: 0x001E16CB
		[NullableContext(1)]
		public static LevelPlayVarResponse Create()
		{
			return new LevelPlayVarResponse();
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x0600CCF7 RID: 52471 RVA: 0x001E34D2 File Offset: 0x001E16D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x0600CCF8 RID: 52472 RVA: 0x001E34D5 File Offset: 0x001E16D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayVarResponse.Descriptor;
			}
		}

		// Token: 0x0600CCF9 RID: 52473 RVA: 0x001E34DC File Offset: 0x001E16DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarResponse()
		{
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x001E34EF File Offset: 0x001E16EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarResponse(LevelPlayVarResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.vars_ = other.vars_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x001E3525 File Offset: 0x001E1725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayVarResponse Clone()
		{
			return new LevelPlayVarResponse(this);
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x0600CCFC RID: 52476 RVA: 0x001E352D File Offset: 0x001E172D
		// (set) Token: 0x0600CCFD RID: 52477 RVA: 0x001E3535 File Offset: 0x001E1735
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

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x0600CCFE RID: 52478 RVA: 0x001E353E File Offset: 0x001E173E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<string, VarDefinePb> Vars
		{
			get
			{
				return this.vars_;
			}
		}

		// Token: 0x0600CCFF RID: 52479 RVA: 0x001E3546 File Offset: 0x001E1746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayVarResponse);
		}

		// Token: 0x0600CD00 RID: 52480 RVA: 0x001E3554 File Offset: 0x001E1754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayVarResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Vars.Equals(other.Vars) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD01 RID: 52481 RVA: 0x001E35A4 File Offset: 0x001E17A4
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

		// Token: 0x0600CD02 RID: 52482 RVA: 0x001E35F7 File Offset: 0x001E17F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD03 RID: 52483 RVA: 0x001E3604 File Offset: 0x001E1804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD04 RID: 52484 RVA: 0x001E3610 File Offset: 0x001E1810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.vars_.WriteTo(ref output, LevelPlayVarResponse._map_vars_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD05 RID: 52485 RVA: 0x001E3660 File Offset: 0x001E1860
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

		// Token: 0x0600CD06 RID: 52486 RVA: 0x001E36B4 File Offset: 0x001E18B4
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

		// Token: 0x0600CD07 RID: 52487 RVA: 0x001E3701 File Offset: 0x001E1901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD08 RID: 52488 RVA: 0x001E370C File Offset: 0x001E190C
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.vars_.AddEntriesFrom(ref input, LevelPlayVarResponse._map_vars_codec);
				}
			}
		}

		// Token: 0x040056D3 RID: 22227
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056D4 RID: 22228
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040056D5 RID: 22229
		private ErrorCode errorCode_;

		// Token: 0x040056D6 RID: 22230
		public const int VarsFieldNumber = 1;

		// Token: 0x040056D7 RID: 22231
		private static readonly MapField<string, VarDefinePb>.Codec _map_vars_codec = new MapField<string, VarDefinePb>.Codec(FieldCodec.ForString(10U, ""), FieldCodec.ForMessage<VarDefinePb>(18U, VarDefinePb.Parser), 10U);

		// Token: 0x040056D8 RID: 22232
		private readonly MapField<string, VarDefinePb> vars_ = new MapField<string, VarDefinePb>();
	}
}
