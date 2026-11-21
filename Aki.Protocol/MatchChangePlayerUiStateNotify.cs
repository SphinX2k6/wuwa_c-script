using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099C RID: 2460
	[NetMessage(EMessageId.MatchChangePlayerUiStateNotify)]
	public sealed class MatchChangePlayerUiStateNotify : IMessage<MatchChangePlayerUiStateNotify>, IMessage, IEquatable<MatchChangePlayerUiStateNotify>, IDeepCloneable<MatchChangePlayerUiStateNotify>, IBufferMessage
	{
		// Token: 0x0600D85F RID: 55391 RVA: 0x001FD115 File Offset: 0x001FB315
		[NullableContext(1)]
		public static MatchChangePlayerUiStateNotify Create()
		{
			return new MatchChangePlayerUiStateNotify();
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x0600D860 RID: 55392 RVA: 0x001FD11C File Offset: 0x001FB31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x0600D861 RID: 55393 RVA: 0x001FD11F File Offset: 0x001FB31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchChangePlayerUiStateNotify.Descriptor;
			}
		}

		// Token: 0x0600D862 RID: 55394 RVA: 0x001FD126 File Offset: 0x001FB326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateNotify()
		{
		}

		// Token: 0x0600D863 RID: 55395 RVA: 0x001FD12E File Offset: 0x001FB32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateNotify(MatchChangePlayerUiStateNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.matchUiState_ = other.matchUiState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D864 RID: 55396 RVA: 0x001FD15F File Offset: 0x001FB35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchChangePlayerUiStateNotify Clone()
		{
			return new MatchChangePlayerUiStateNotify(this);
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x0600D865 RID: 55397 RVA: 0x001FD167 File Offset: 0x001FB367
		// (set) Token: 0x0600D866 RID: 55398 RVA: 0x001FD16F File Offset: 0x001FB36F
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

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x0600D867 RID: 55399 RVA: 0x001FD178 File Offset: 0x001FB378
		// (set) Token: 0x0600D868 RID: 55400 RVA: 0x001FD180 File Offset: 0x001FB380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMatchPlayerUiState MatchUiState
		{
			get
			{
				return this.matchUiState_;
			}
			set
			{
				this.matchUiState_ = value;
			}
		}

		// Token: 0x0600D869 RID: 55401 RVA: 0x001FD189 File Offset: 0x001FB389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchChangePlayerUiStateNotify);
		}

		// Token: 0x0600D86A RID: 55402 RVA: 0x001FD197 File Offset: 0x001FB397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchChangePlayerUiStateNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.MatchUiState == other.MatchUiState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D86B RID: 55403 RVA: 0x001FD1D8 File Offset: 0x001FB3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				num ^= this.MatchUiState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x001FD236 File Offset: 0x001FB436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D86D RID: 55405 RVA: 0x001FD243 File Offset: 0x001FB443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D86E RID: 55406 RVA: 0x001FD24C File Offset: 0x001FB44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.MatchUiState);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D86F RID: 55407 RVA: 0x001FD2A8 File Offset: 0x001FB4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.MatchUiState != EMatchPlayerUiState.Wait)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MatchUiState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x001FD300 File Offset: 0x001FB500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchChangePlayerUiStateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.MatchUiState != EMatchPlayerUiState.Wait)
			{
				this.MatchUiState = other.MatchUiState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D871 RID: 55409 RVA: 0x001FD350 File Offset: 0x001FB550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D872 RID: 55410 RVA: 0x001FD35C File Offset: 0x001FB55C
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
					if (num != 24U)
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
					this.MatchUiState = (EMatchPlayerUiState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005A83 RID: 23171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A84 RID: 23172
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04005A85 RID: 23173
		private int playerId_;

		// Token: 0x04005A86 RID: 23174
		public const int MatchUiStateFieldNumber = 2;

		// Token: 0x04005A87 RID: 23175
		private EMatchPlayerUiState matchUiState_;
	}
}
