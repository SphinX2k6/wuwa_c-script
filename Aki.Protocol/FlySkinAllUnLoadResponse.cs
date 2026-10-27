using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060D RID: 1549
	[NetMessage(EMessageId.FlySkinAllUnLoadResponse)]
	public sealed class FlySkinAllUnLoadResponse : IMessage<FlySkinAllUnLoadResponse>, IMessage, IEquatable<FlySkinAllUnLoadResponse>, IDeepCloneable<FlySkinAllUnLoadResponse>, IBufferMessage
	{
		// Token: 0x06008F2C RID: 36652 RVA: 0x0015AEE9 File Offset: 0x001590E9
		[NullableContext(1)]
		public static FlySkinAllUnLoadResponse Create()
		{
			return new FlySkinAllUnLoadResponse();
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06008F2D RID: 36653 RVA: 0x0015AEF0 File Offset: 0x001590F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06008F2E RID: 36654 RVA: 0x0015AEF3 File Offset: 0x001590F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinAllUnLoadResponse.Descriptor;
			}
		}

		// Token: 0x06008F2F RID: 36655 RVA: 0x0015AEFA File Offset: 0x001590FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadResponse()
		{
		}

		// Token: 0x06008F30 RID: 36656 RVA: 0x0015AF0D File Offset: 0x0015910D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadResponse(FlySkinAllUnLoadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.unLoadSkinRoles_ = other.unLoadSkinRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F31 RID: 36657 RVA: 0x0015AF43 File Offset: 0x00159143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinAllUnLoadResponse Clone()
		{
			return new FlySkinAllUnLoadResponse(this);
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x06008F32 RID: 36658 RVA: 0x0015AF4B File Offset: 0x0015914B
		// (set) Token: 0x06008F33 RID: 36659 RVA: 0x0015AF53 File Offset: 0x00159153
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

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x06008F34 RID: 36660 RVA: 0x0015AF5C File Offset: 0x0015915C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLoadSkinRoles
		{
			get
			{
				return this.unLoadSkinRoles_;
			}
		}

		// Token: 0x06008F35 RID: 36661 RVA: 0x0015AF64 File Offset: 0x00159164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinAllUnLoadResponse);
		}

		// Token: 0x06008F36 RID: 36662 RVA: 0x0015AF74 File Offset: 0x00159174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinAllUnLoadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.unLoadSkinRoles_.Equals(other.unLoadSkinRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x0015AFC4 File Offset: 0x001591C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.unLoadSkinRoles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F38 RID: 36664 RVA: 0x0015B017 File Offset: 0x00159217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0015B024 File Offset: 0x00159224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x0015B030 File Offset: 0x00159230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.unLoadSkinRoles_.WriteTo(ref output, FlySkinAllUnLoadResponse._repeated_unLoadSkinRoles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x0015B080 File Offset: 0x00159280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.unLoadSkinRoles_.CalculateSize(FlySkinAllUnLoadResponse._repeated_unLoadSkinRoles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x0015B0D4 File Offset: 0x001592D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinAllUnLoadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.unLoadSkinRoles_.Add(other.unLoadSkinRoles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F3D RID: 36669 RVA: 0x0015B121 File Offset: 0x00159321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x0015B12C File Offset: 0x0015932C
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
				if (num != 16U)
				{
					if (num != 88U && num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unLoadSkinRoles_.AddEntriesFrom(ref input, FlySkinAllUnLoadResponse._repeated_unLoadSkinRoles_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004593 RID: 17811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004594 RID: 17812
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004595 RID: 17813
		private ErrorCode errorCode_;

		// Token: 0x04004596 RID: 17814
		public const int UnLoadSkinRolesFieldNumber = 11;

		// Token: 0x04004597 RID: 17815
		private static readonly FieldCodec<int> _repeated_unLoadSkinRoles_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04004598 RID: 17816
		private readonly RepeatedField<int> unLoadSkinRoles_ = new RepeatedField<int>();
	}
}
