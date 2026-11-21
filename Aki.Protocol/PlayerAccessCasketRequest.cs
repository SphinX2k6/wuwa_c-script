using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D69 RID: 3433
	[NetMessage(EMessageId.PlayerAccessCasketRequest)]
	public sealed class PlayerAccessCasketRequest : IMessage<PlayerAccessCasketRequest>, IMessage, IEquatable<PlayerAccessCasketRequest>, IDeepCloneable<PlayerAccessCasketRequest>, IBufferMessage
	{
		// Token: 0x0601287E RID: 75902 RVA: 0x002B4873 File Offset: 0x002B2A73
		[NullableContext(1)]
		public static PlayerAccessCasketRequest Create()
		{
			return new PlayerAccessCasketRequest();
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x0601287F RID: 75903 RVA: 0x002B487A File Offset: 0x002B2A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x06012880 RID: 75904 RVA: 0x002B487D File Offset: 0x002B2A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessCasketRequest.Descriptor;
			}
		}

		// Token: 0x06012881 RID: 75905 RVA: 0x002B4884 File Offset: 0x002B2A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketRequest()
		{
		}

		// Token: 0x06012882 RID: 75906 RVA: 0x002B4898 File Offset: 0x002B2A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketRequest(PlayerAccessCasketRequest other) : this()
		{
			this.accessEntityIncIds_ = other.accessEntityIncIds_.Clone();
			this.isEnter_ = other.isEnter_;
			this.casketEntityIncId_ = other.casketEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012883 RID: 75907 RVA: 0x002B48E5 File Offset: 0x002B2AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketRequest Clone()
		{
			return new PlayerAccessCasketRequest(this);
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x06012884 RID: 75908 RVA: 0x002B48ED File Offset: 0x002B2AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AccessEntityIncIds
		{
			get
			{
				return this.accessEntityIncIds_;
			}
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x06012885 RID: 75909 RVA: 0x002B48F5 File Offset: 0x002B2AF5
		// (set) Token: 0x06012886 RID: 75910 RVA: 0x002B48FD File Offset: 0x002B2AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x06012887 RID: 75911 RVA: 0x002B4906 File Offset: 0x002B2B06
		// (set) Token: 0x06012888 RID: 75912 RVA: 0x002B490E File Offset: 0x002B2B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasketEntityIncId
		{
			get
			{
				return this.casketEntityIncId_;
			}
			set
			{
				this.casketEntityIncId_ = value;
			}
		}

		// Token: 0x06012889 RID: 75913 RVA: 0x002B4917 File Offset: 0x002B2B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessCasketRequest);
		}

		// Token: 0x0601288A RID: 75914 RVA: 0x002B4928 File Offset: 0x002B2B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessCasketRequest other)
		{
			return other != null && (other == this || (this.accessEntityIncIds_.Equals(other.accessEntityIncIds_) && this.IsEnter == other.IsEnter && this.CasketEntityIncId == other.CasketEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601288B RID: 75915 RVA: 0x002B4988 File Offset: 0x002B2B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.accessEntityIncIds_.GetHashCode();
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this.CasketEntityIncId != 0L)
			{
				num ^= this.CasketEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601288C RID: 75916 RVA: 0x002B49EE File Offset: 0x002B2BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601288D RID: 75917 RVA: 0x002B49FB File Offset: 0x002B2BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601288E RID: 75918 RVA: 0x002B4A04 File Offset: 0x002B2C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEnter)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsEnter);
			}
			this.accessEntityIncIds_.WriteTo(ref output, PlayerAccessCasketRequest._repeated_accessEntityIncIds_codec);
			if (this.CasketEntityIncId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601288F RID: 75919 RVA: 0x002B4A70 File Offset: 0x002B2C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.accessEntityIncIds_.CalculateSize(PlayerAccessCasketRequest._repeated_accessEntityIncIds_codec);
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this.CasketEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012890 RID: 75920 RVA: 0x002B4AD0 File Offset: 0x002B2CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAccessCasketRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.accessEntityIncIds_.Add(other.accessEntityIncIds_);
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			if (other.CasketEntityIncId != 0L)
			{
				this.CasketEntityIncId = other.CasketEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012891 RID: 75921 RVA: 0x002B4B31 File Offset: 0x002B2D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012892 RID: 75922 RVA: 0x002B4B3C File Offset: 0x002B2D3C
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
				if (num <= 104U)
				{
					if (num == 8U)
					{
						this.IsEnter = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 106U)
					{
						goto IL_45;
					}
					if (num == 120U)
					{
						this.CasketEntityIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.accessEntityIncIds_.AddEntriesFrom(ref input, PlayerAccessCasketRequest._repeated_accessEntityIncIds_codec);
			}
		}

		// Token: 0x04007381 RID: 29569
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007382 RID: 29570
		public const int AccessEntityIncIdsFieldNumber = 13;

		// Token: 0x04007383 RID: 29571
		private static readonly FieldCodec<long> _repeated_accessEntityIncIds_codec = FieldCodec.ForInt64(106U);

		// Token: 0x04007384 RID: 29572
		private readonly RepeatedField<long> accessEntityIncIds_ = new RepeatedField<long>();

		// Token: 0x04007385 RID: 29573
		public const int IsEnterFieldNumber = 1;

		// Token: 0x04007386 RID: 29574
		private bool isEnter_;

		// Token: 0x04007387 RID: 29575
		public const int CasketEntityIncIdFieldNumber = 15;

		// Token: 0x04007388 RID: 29576
		private long casketEntityIncId_;
	}
}
