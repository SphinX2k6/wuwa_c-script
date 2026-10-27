using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000100 RID: 256
	[NetMessage(EMessageId.ApplyerEnterSceneNotify)]
	public sealed class ApplyerEnterSceneNotify : IMessage<ApplyerEnterSceneNotify>, IMessage, IEquatable<ApplyerEnterSceneNotify>, IDeepCloneable<ApplyerEnterSceneNotify>, IBufferMessage
	{
		// Token: 0x060023F6 RID: 9206 RVA: 0x0005FDBB File Offset: 0x0005DFBB
		[NullableContext(1)]
		public static ApplyerEnterSceneNotify Create()
		{
			return new ApplyerEnterSceneNotify();
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0005FDC2 File Offset: 0x0005DFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x0005FDC5 File Offset: 0x0005DFC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyerEnterSceneNotify.Descriptor;
			}
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0005FDCC File Offset: 0x0005DFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyerEnterSceneNotify()
		{
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x0005FDD4 File Offset: 0x0005DFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyerEnterSceneNotify(ApplyerEnterSceneNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0005FE05 File Offset: 0x0005E005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyerEnterSceneNotify Clone()
		{
			return new ApplyerEnterSceneNotify(this);
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x0005FE0D File Offset: 0x0005E00D
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x0005FE15 File Offset: 0x0005E015
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x0005FE1E File Offset: 0x0005E01E
		// (set) Token: 0x060023FF RID: 9215 RVA: 0x0005FE26 File Offset: 0x0005E026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0005FE2F File Offset: 0x0005E02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyerEnterSceneNotify);
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x0005FE3D File Offset: 0x0005E03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyerEnterSceneNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0005FE7C File Offset: 0x0005E07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0005FEDA File Offset: 0x0005E0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0005FEE7 File Offset: 0x0005E0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0005FEF0 File Offset: 0x0005E0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0005FF4C File Offset: 0x0005E14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0005FFA4 File Offset: 0x0005E1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyerEnterSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0005FFF4 File Offset: 0x0005E1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00060000 File Offset: 0x0005E200
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
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002528 RID: 9512
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002529 RID: 9513
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400252A RID: 9514
		private ErrorCode errorCode_;

		// Token: 0x0400252B RID: 9515
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x0400252C RID: 9516
		private int playerId_;
	}
}
