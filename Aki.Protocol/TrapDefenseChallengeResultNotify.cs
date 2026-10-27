using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141A RID: 5146
	[NetMessage(EMessageId.TrapDefenseChallengeResultNotify)]
	public sealed class TrapDefenseChallengeResultNotify : IMessage<TrapDefenseChallengeResultNotify>, IMessage, IEquatable<TrapDefenseChallengeResultNotify>, IDeepCloneable<TrapDefenseChallengeResultNotify>, IBufferMessage
	{
		// Token: 0x0601B470 RID: 111728 RVA: 0x003F3D75 File Offset: 0x003F1F75
		[NullableContext(1)]
		public static TrapDefenseChallengeResultNotify Create()
		{
			return new TrapDefenseChallengeResultNotify();
		}

		// Token: 0x17005C04 RID: 23556
		// (get) Token: 0x0601B471 RID: 111729 RVA: 0x003F3D7C File Offset: 0x003F1F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C05 RID: 23557
		// (get) Token: 0x0601B472 RID: 111730 RVA: 0x003F3D7F File Offset: 0x003F1F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeResultNotify.Descriptor;
			}
		}

		// Token: 0x0601B473 RID: 111731 RVA: 0x003F3D86 File Offset: 0x003F1F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeResultNotify()
		{
		}

		// Token: 0x0601B474 RID: 111732 RVA: 0x003F3D8E File Offset: 0x003F1F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeResultNotify(TrapDefenseChallengeResultNotify other) : this()
		{
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B475 RID: 111733 RVA: 0x003F3DC3 File Offset: 0x003F1FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeResultNotify Clone()
		{
			return new TrapDefenseChallengeResultNotify(this);
		}

		// Token: 0x17005C06 RID: 23558
		// (get) Token: 0x0601B476 RID: 111734 RVA: 0x003F3DCB File Offset: 0x003F1FCB
		// (set) Token: 0x0601B477 RID: 111735 RVA: 0x003F3DD3 File Offset: 0x003F1FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseResultInfo Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0601B478 RID: 111736 RVA: 0x003F3DDC File Offset: 0x003F1FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeResultNotify);
		}

		// Token: 0x0601B479 RID: 111737 RVA: 0x003F3DEA File Offset: 0x003F1FEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeResultNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B47A RID: 111738 RVA: 0x003F3E20 File Offset: 0x003F2020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B47B RID: 111739 RVA: 0x003F3E5C File Offset: 0x003F205C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B47C RID: 111740 RVA: 0x003F3E69 File Offset: 0x003F2069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B47D RID: 111741 RVA: 0x003F3E72 File Offset: 0x003F2072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.result_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B47E RID: 111742 RVA: 0x003F3EA4 File Offset: 0x003F20A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B47F RID: 111743 RVA: 0x003F3EE4 File Offset: 0x003F20E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseChallengeResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new TrapDefenseResultInfo();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B480 RID: 111744 RVA: 0x003F3F38 File Offset: 0x003F2138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B481 RID: 111745 RVA: 0x003F3F44 File Offset: 0x003F2144
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
					if (this.result_ == null)
					{
						this.Result = new TrapDefenseResultInfo();
					}
					input.ReadMessage(this.Result);
				}
			}
		}

		// Token: 0x04009DB8 RID: 40376
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DB9 RID: 40377
		public const int ResultFieldNumber = 15;

		// Token: 0x04009DBA RID: 40378
		private TrapDefenseResultInfo result_;
	}
}
