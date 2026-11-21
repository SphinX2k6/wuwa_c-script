using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3B RID: 3643
	[NetMessage(EMessageId.RacingBetsBulletScreenResponse)]
	public sealed class RacingBetsBulletScreenResponse : IMessage<RacingBetsBulletScreenResponse>, IMessage, IEquatable<RacingBetsBulletScreenResponse>, IDeepCloneable<RacingBetsBulletScreenResponse>, IBufferMessage
	{
		// Token: 0x06013977 RID: 80247 RVA: 0x002D9EC4 File Offset: 0x002D80C4
		[NullableContext(1)]
		public static RacingBetsBulletScreenResponse Create()
		{
			return new RacingBetsBulletScreenResponse();
		}

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x06013978 RID: 80248 RVA: 0x002D9ECB File Offset: 0x002D80CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x06013979 RID: 80249 RVA: 0x002D9ECE File Offset: 0x002D80CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsBulletScreenResponse.Descriptor;
			}
		}

		// Token: 0x0601397A RID: 80250 RVA: 0x002D9ED5 File Offset: 0x002D80D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenResponse()
		{
		}

		// Token: 0x0601397B RID: 80251 RVA: 0x002D9EDD File Offset: 0x002D80DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenResponse(RacingBetsBulletScreenResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601397C RID: 80252 RVA: 0x002D9F02 File Offset: 0x002D8102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenResponse Clone()
		{
			return new RacingBetsBulletScreenResponse(this);
		}

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x0601397D RID: 80253 RVA: 0x002D9F0A File Offset: 0x002D810A
		// (set) Token: 0x0601397E RID: 80254 RVA: 0x002D9F12 File Offset: 0x002D8112
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

		// Token: 0x0601397F RID: 80255 RVA: 0x002D9F1B File Offset: 0x002D811B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsBulletScreenResponse);
		}

		// Token: 0x06013980 RID: 80256 RVA: 0x002D9F29 File Offset: 0x002D8129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsBulletScreenResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013981 RID: 80257 RVA: 0x002D9F58 File Offset: 0x002D8158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013982 RID: 80258 RVA: 0x002D9F9D File Offset: 0x002D819D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013983 RID: 80259 RVA: 0x002D9FAA File Offset: 0x002D81AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013984 RID: 80260 RVA: 0x002D9FB3 File Offset: 0x002D81B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013985 RID: 80261 RVA: 0x002D9FE8 File Offset: 0x002D81E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013986 RID: 80262 RVA: 0x002DA026 File Offset: 0x002D8226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsBulletScreenResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013987 RID: 80263 RVA: 0x002DA057 File Offset: 0x002D8257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013988 RID: 80264 RVA: 0x002DA060 File Offset: 0x002D8260
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007871 RID: 30833
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007872 RID: 30834
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007873 RID: 30835
		private ErrorCode errorCode_;
	}
}
