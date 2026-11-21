using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069D RID: 1693
	[NetMessage(EMessageId.GameStatsShowResponse)]
	public sealed class GameStatsShowResponse : IMessage<GameStatsShowResponse>, IMessage, IEquatable<GameStatsShowResponse>, IDeepCloneable<GameStatsShowResponse>, IBufferMessage
	{
		// Token: 0x06009BC0 RID: 39872 RVA: 0x0017B74E File Offset: 0x0017994E
		[NullableContext(1)]
		public static GameStatsShowResponse Create()
		{
			return new GameStatsShowResponse();
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06009BC1 RID: 39873 RVA: 0x0017B755 File Offset: 0x00179955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06009BC2 RID: 39874 RVA: 0x0017B758 File Offset: 0x00179958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameStatsShowResponse.Descriptor;
			}
		}

		// Token: 0x06009BC3 RID: 39875 RVA: 0x0017B75F File Offset: 0x0017995F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowResponse()
		{
		}

		// Token: 0x06009BC4 RID: 39876 RVA: 0x0017B767 File Offset: 0x00179967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowResponse(GameStatsShowResponse other) : this()
		{
			this.googleGameStatsShow_ = ((other.googleGameStatsShow_ != null) ? other.googleGameStatsShow_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BC5 RID: 39877 RVA: 0x0017B79C File Offset: 0x0017999C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowResponse Clone()
		{
			return new GameStatsShowResponse(this);
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06009BC6 RID: 39878 RVA: 0x0017B7A4 File Offset: 0x001799A4
		// (set) Token: 0x06009BC7 RID: 39879 RVA: 0x0017B7AC File Offset: 0x001799AC
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

		// Token: 0x06009BC8 RID: 39880 RVA: 0x0017B7B5 File Offset: 0x001799B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameStatsShowResponse);
		}

		// Token: 0x06009BC9 RID: 39881 RVA: 0x0017B7C3 File Offset: 0x001799C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameStatsShowResponse other)
		{
			return other != null && (other == this || (object.Equals(this.GoogleGameStatsShow, other.GoogleGameStatsShow) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x0017B7F8 File Offset: 0x001799F8
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

		// Token: 0x06009BCB RID: 39883 RVA: 0x0017B834 File Offset: 0x00179A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x0017B841 File Offset: 0x00179A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x0017B84A File Offset: 0x00179A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.googleGameStatsShow_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GoogleGameStatsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x0017B87C File Offset: 0x00179A7C
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

		// Token: 0x06009BCF RID: 39887 RVA: 0x0017B8BC File Offset: 0x00179ABC
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

		// Token: 0x06009BD0 RID: 39888 RVA: 0x0017B910 File Offset: 0x00179B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BD1 RID: 39889 RVA: 0x0017B91C File Offset: 0x00179B1C
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
				if (num != 18U)
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

		// Token: 0x040049E2 RID: 18914
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049E3 RID: 18915
		public const int GoogleGameStatsShowFieldNumber = 2;

		// Token: 0x040049E4 RID: 18916
		private GoogleGameStatsShow googleGameStatsShow_;
	}
}
