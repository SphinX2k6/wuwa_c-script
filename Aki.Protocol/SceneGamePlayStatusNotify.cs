using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001190 RID: 4496
	[NetMessage(EMessageId.SceneGamePlayStatusNotify)]
	public sealed class SceneGamePlayStatusNotify : IMessage<SceneGamePlayStatusNotify>, IMessage, IEquatable<SceneGamePlayStatusNotify>, IDeepCloneable<SceneGamePlayStatusNotify>, IBufferMessage
	{
		// Token: 0x06018022 RID: 98338 RVA: 0x0037E400 File Offset: 0x0037C600
		[NullableContext(1)]
		public static SceneGamePlayStatusNotify Create()
		{
			return new SceneGamePlayStatusNotify();
		}

		// Token: 0x170050D1 RID: 20689
		// (get) Token: 0x06018023 RID: 98339 RVA: 0x0037E407 File Offset: 0x0037C607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170050D2 RID: 20690
		// (get) Token: 0x06018024 RID: 98340 RVA: 0x0037E40A File Offset: 0x0037C60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneGamePlayStatusNotify.Descriptor;
			}
		}

		// Token: 0x06018025 RID: 98341 RVA: 0x0037E411 File Offset: 0x0037C611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayStatusNotify()
		{
		}

		// Token: 0x06018026 RID: 98342 RVA: 0x0037E419 File Offset: 0x0037C619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayStatusNotify(SceneGamePlayStatusNotify other) : this()
		{
			this.gamePlayId_ = other.gamePlayId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018027 RID: 98343 RVA: 0x0037E44A File Offset: 0x0037C64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneGamePlayStatusNotify Clone()
		{
			return new SceneGamePlayStatusNotify(this);
		}

		// Token: 0x170050D3 RID: 20691
		// (get) Token: 0x06018028 RID: 98344 RVA: 0x0037E452 File Offset: 0x0037C652
		// (set) Token: 0x06018029 RID: 98345 RVA: 0x0037E45A File Offset: 0x0037C65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayId
		{
			get
			{
				return this.gamePlayId_;
			}
			set
			{
				this.gamePlayId_ = value;
			}
		}

		// Token: 0x170050D4 RID: 20692
		// (get) Token: 0x0601802A RID: 98346 RVA: 0x0037E463 File Offset: 0x0037C663
		// (set) Token: 0x0601802B RID: 98347 RVA: 0x0037E46B File Offset: 0x0037C66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0601802C RID: 98348 RVA: 0x0037E474 File Offset: 0x0037C674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneGamePlayStatusNotify);
		}

		// Token: 0x0601802D RID: 98349 RVA: 0x0037E482 File Offset: 0x0037C682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneGamePlayStatusNotify other)
		{
			return other != null && (other == this || (this.GamePlayId == other.GamePlayId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601802E RID: 98350 RVA: 0x0037E4C0 File Offset: 0x0037C6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601802F RID: 98351 RVA: 0x0037E518 File Offset: 0x0037C718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018030 RID: 98352 RVA: 0x0037E525 File Offset: 0x0037C725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018031 RID: 98353 RVA: 0x0037E530 File Offset: 0x0037C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Status);
			}
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018032 RID: 98354 RVA: 0x0037E58C File Offset: 0x0037C78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018033 RID: 98355 RVA: 0x0037E5E4 File Offset: 0x0037C7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneGamePlayStatusNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018034 RID: 98356 RVA: 0x0037E634 File Offset: 0x0037C834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018035 RID: 98357 RVA: 0x0037E640 File Offset: 0x0037C840
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GamePlayId = input.ReadInt32();
					}
				}
				else
				{
					this.Status = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008EF5 RID: 36597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EF6 RID: 36598
		public const int GamePlayIdFieldNumber = 6;

		// Token: 0x04008EF7 RID: 36599
		private int gamePlayId_;

		// Token: 0x04008EF8 RID: 36600
		public const int StatusFieldNumber = 5;

		// Token: 0x04008EF9 RID: 36601
		private int status_;
	}
}
