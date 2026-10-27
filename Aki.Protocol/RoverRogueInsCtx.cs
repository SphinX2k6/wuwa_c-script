using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001107 RID: 4359
	public sealed class RoverRogueInsCtx : IMessage<RoverRogueInsCtx>, IMessage, IEquatable<RoverRogueInsCtx>, IDeepCloneable<RoverRogueInsCtx>, IBufferMessage
	{
		// Token: 0x060173F8 RID: 95224 RVA: 0x003602A5 File Offset: 0x0035E4A5
		[NullableContext(1)]
		public static RoverRogueInsCtx Create()
		{
			return new RoverRogueInsCtx();
		}

		// Token: 0x17004DF3 RID: 19955
		// (get) Token: 0x060173F9 RID: 95225 RVA: 0x003602AC File Offset: 0x0035E4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DF4 RID: 19956
		// (get) Token: 0x060173FA RID: 95226 RVA: 0x003602AF File Offset: 0x0035E4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInsCtx.Descriptor;
			}
		}

		// Token: 0x060173FB RID: 95227 RVA: 0x003602B6 File Offset: 0x0035E4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsCtx()
		{
		}

		// Token: 0x060173FC RID: 95228 RVA: 0x003602CC File Offset: 0x0035E4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsCtx(RoverRogueInsCtx other) : this()
		{
			this.roverId_ = other.roverId_;
			this.continueLastProgress_ = other.continueLastProgress_;
			this.equippedLootIds_ = other.equippedLootIds_.Clone();
			this.roverRoleType_ = other.roverRoleType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060173FD RID: 95229 RVA: 0x00360325 File Offset: 0x0035E525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsCtx Clone()
		{
			return new RoverRogueInsCtx(this);
		}

		// Token: 0x17004DF5 RID: 19957
		// (get) Token: 0x060173FE RID: 95230 RVA: 0x0036032D File Offset: 0x0035E52D
		// (set) Token: 0x060173FF RID: 95231 RVA: 0x00360335 File Offset: 0x0035E535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverId
		{
			get
			{
				return this.roverId_;
			}
			set
			{
				this.roverId_ = value;
			}
		}

		// Token: 0x17004DF6 RID: 19958
		// (get) Token: 0x06017400 RID: 95232 RVA: 0x0036033E File Offset: 0x0035E53E
		// (set) Token: 0x06017401 RID: 95233 RVA: 0x00360346 File Offset: 0x0035E546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ContinueLastProgress
		{
			get
			{
				return this.continueLastProgress_;
			}
			set
			{
				this.continueLastProgress_ = value;
			}
		}

		// Token: 0x17004DF7 RID: 19959
		// (get) Token: 0x06017402 RID: 95234 RVA: 0x0036034F File Offset: 0x0035E54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquippedLootIds
		{
			get
			{
				return this.equippedLootIds_;
			}
		}

		// Token: 0x17004DF8 RID: 19960
		// (get) Token: 0x06017403 RID: 95235 RVA: 0x00360357 File Offset: 0x0035E557
		// (set) Token: 0x06017404 RID: 95236 RVA: 0x0036035F File Offset: 0x0035E55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoverRoleType
		{
			get
			{
				return this.roverRoleType_;
			}
			set
			{
				this.roverRoleType_ = value;
			}
		}

		// Token: 0x06017405 RID: 95237 RVA: 0x00360368 File Offset: 0x0035E568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInsCtx);
		}

		// Token: 0x06017406 RID: 95238 RVA: 0x00360378 File Offset: 0x0035E578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInsCtx other)
		{
			return other != null && (other == this || (this.RoverId == other.RoverId && this.ContinueLastProgress == other.ContinueLastProgress && this.equippedLootIds_.Equals(other.equippedLootIds_) && this.RoverRoleType == other.RoverRoleType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017407 RID: 95239 RVA: 0x003603E8 File Offset: 0x0035E5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoverId != 0)
			{
				num ^= this.RoverId.GetHashCode();
			}
			if (this.ContinueLastProgress)
			{
				num ^= this.ContinueLastProgress.GetHashCode();
			}
			num ^= this.equippedLootIds_.GetHashCode();
			if (this.RoverRoleType != 0)
			{
				num ^= this.RoverRoleType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017408 RID: 95240 RVA: 0x00360467 File Offset: 0x0035E667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017409 RID: 95241 RVA: 0x00360474 File Offset: 0x0035E674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601740A RID: 95242 RVA: 0x00360480 File Offset: 0x0035E680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoverId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoverId);
			}
			if (this.ContinueLastProgress)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ContinueLastProgress);
			}
			this.equippedLootIds_.WriteTo(ref output, RoverRogueInsCtx._repeated_equippedLootIds_codec);
			if (this.RoverRoleType != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoverRoleType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601740B RID: 95243 RVA: 0x00360508 File Offset: 0x0035E708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoverId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoverId);
			}
			if (this.ContinueLastProgress)
			{
				num += 2;
			}
			num += this.equippedLootIds_.CalculateSize(RoverRogueInsCtx._repeated_equippedLootIds_codec);
			if (this.RoverRoleType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoverRoleType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601740C RID: 95244 RVA: 0x00360580 File Offset: 0x0035E780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueInsCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoverId != 0)
			{
				this.RoverId = other.RoverId;
			}
			if (other.ContinueLastProgress)
			{
				this.ContinueLastProgress = other.ContinueLastProgress;
			}
			this.equippedLootIds_.Add(other.equippedLootIds_);
			if (other.RoverRoleType != 0)
			{
				this.RoverRoleType = other.RoverRoleType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601740D RID: 95245 RVA: 0x003605F5 File Offset: 0x0035E7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601740E RID: 95246 RVA: 0x00360600 File Offset: 0x0035E800
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoverId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ContinueLastProgress = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U || num == 26U)
					{
						this.equippedLootIds_.AddEntriesFrom(ref input, RoverRogueInsCtx._repeated_equippedLootIds_codec);
						continue;
					}
					if (num == 32U)
					{
						this.RoverRoleType = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008A52 RID: 35410
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A53 RID: 35411
		public const int RoverIdFieldNumber = 1;

		// Token: 0x04008A54 RID: 35412
		private int roverId_;

		// Token: 0x04008A55 RID: 35413
		public const int ContinueLastProgressFieldNumber = 2;

		// Token: 0x04008A56 RID: 35414
		private bool continueLastProgress_;

		// Token: 0x04008A57 RID: 35415
		public const int EquippedLootIdsFieldNumber = 3;

		// Token: 0x04008A58 RID: 35416
		private static readonly FieldCodec<int> _repeated_equippedLootIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008A59 RID: 35417
		private readonly RepeatedField<int> equippedLootIds_ = new RepeatedField<int>();

		// Token: 0x04008A5A RID: 35418
		public const int RoverRoleTypeFieldNumber = 4;

		// Token: 0x04008A5B RID: 35419
		private int roverRoleType_;
	}
}
