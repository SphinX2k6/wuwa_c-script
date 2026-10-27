using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B1 RID: 1713
	[NetMessage(EMessageId.GameStatsShowResponse)]
	public sealed class GameStatsShowResponse : IMessage<GameStatsShowResponse>, IMessage, IEquatable<GameStatsShowResponse>, IDeepCloneable<GameStatsShowResponse>, IBufferMessage
	{
		// Token: 0x06009D16 RID: 40214 RVA: 0x0017E17E File Offset: 0x0017C37E
		[NullableContext(1)]
		public static GameStatsShowResponse Create()
		{
			return new GameStatsShowResponse();
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06009D17 RID: 40215 RVA: 0x0017E185 File Offset: 0x0017C385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06009D18 RID: 40216 RVA: 0x0017E188 File Offset: 0x0017C388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameStatsShowResponse.Descriptor;
			}
		}

		// Token: 0x06009D19 RID: 40217 RVA: 0x0017E18F File Offset: 0x0017C38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowResponse()
		{
		}

		// Token: 0x06009D1A RID: 40218 RVA: 0x0017E197 File Offset: 0x0017C397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowResponse(GameStatsShowResponse other) : this()
		{
			this.googleGameStatsShow_ = ((other.googleGameStatsShow_ != null) ? other.googleGameStatsShow_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D1B RID: 40219 RVA: 0x0017E1CC File Offset: 0x0017C3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowResponse Clone()
		{
			return new GameStatsShowResponse(this);
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06009D1C RID: 40220 RVA: 0x0017E1D4 File Offset: 0x0017C3D4
		// (set) Token: 0x06009D1D RID: 40221 RVA: 0x0017E1DC File Offset: 0x0017C3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GoogleGameStatsShow GoogleGameStatsShow
		{
			get
			{
				return this.googleGameStatsShow_;
			}
			set
			{
				this.googleGameStatsShow_ = value;
			}
		}

		// Token: 0x06009D1E RID: 40222 RVA: 0x0017E1E5 File Offset: 0x0017C3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameStatsShowResponse);
		}

		// Token: 0x06009D1F RID: 40223 RVA: 0x0017E1F3 File Offset: 0x0017C3F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameStatsShowResponse other)
		{
			return other != null && (other == this || (object.Equals(this.GoogleGameStatsShow, other.GoogleGameStatsShow) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D20 RID: 40224 RVA: 0x0017E228 File Offset: 0x0017C428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.googleGameStatsShow_ != null)
			{
				num ^= this.GoogleGameStatsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D21 RID: 40225 RVA: 0x0017E264 File Offset: 0x0017C464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D22 RID: 40226 RVA: 0x0017E271 File Offset: 0x0017C471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x0017E27A File Offset: 0x0017C47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.googleGameStatsShow_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.GoogleGameStatsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x0017E2AC File Offset: 0x0017C4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.googleGameStatsShow_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GoogleGameStatsShow);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D25 RID: 40229 RVA: 0x0017E2EC File Offset: 0x0017C4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameStatsShowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.googleGameStatsShow_ != null)
			{
				if (this.googleGameStatsShow_ == null)
				{
					this.GoogleGameStatsShow = new GoogleGameStatsShow();
				}
				this.GoogleGameStatsShow.MergeFrom(other.GoogleGameStatsShow);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D26 RID: 40230 RVA: 0x0017E340 File Offset: 0x0017C540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D27 RID: 40231 RVA: 0x0017E34C File Offset: 0x0017C54C
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.googleGameStatsShow_ == null)
					{
						this.GoogleGameStatsShow = new GoogleGameStatsShow();
					}
					input.ReadMessage(this.GoogleGameStatsShow);
				}
			}
		}

		// Token: 0x040049E9 RID: 18921
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049EA RID: 18922
		public const int GoogleGameStatsShowFieldNumber = 7;

		// Token: 0x040049EB RID: 18923
		private GoogleGameStatsShow googleGameStatsShow_;
	}
}
