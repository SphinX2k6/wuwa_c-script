using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BA4 RID: 2980
	[NetMessage(EMessageId.OtherJoinSceneNotify)]
	public sealed class OtherJoinSceneNotify : IMessage<OtherJoinSceneNotify>, IMessage, IEquatable<OtherJoinSceneNotify>, IDeepCloneable<OtherJoinSceneNotify>, IBufferMessage
	{
		// Token: 0x060102DB RID: 66267 RVA: 0x0025D099 File Offset: 0x0025B299
		[NullableContext(1)]
		public static OtherJoinSceneNotify Create()
		{
			return new OtherJoinSceneNotify();
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x060102DC RID: 66268 RVA: 0x0025D0A0 File Offset: 0x0025B2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x060102DD RID: 66269 RVA: 0x0025D0A3 File Offset: 0x0025B2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OtherJoinSceneNotify.Descriptor;
			}
		}

		// Token: 0x060102DE RID: 66270 RVA: 0x0025D0AA File Offset: 0x0025B2AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OtherJoinSceneNotify()
		{
		}

		// Token: 0x060102DF RID: 66271 RVA: 0x0025D0B2 File Offset: 0x0025B2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OtherJoinSceneNotify(OtherJoinSceneNotify other) : this()
		{
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060102E0 RID: 66272 RVA: 0x0025D0E7 File Offset: 0x0025B2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OtherJoinSceneNotify Clone()
		{
			return new OtherJoinSceneNotify(this);
		}

		// Token: 0x1700350E RID: 13582
		// (get) Token: 0x060102E1 RID: 66273 RVA: 0x0025D0EF File Offset: 0x0025B2EF
		// (set) Token: 0x060102E2 RID: 66274 RVA: 0x0025D0F7 File Offset: 0x0025B2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScenePlayerInformation PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x060102E3 RID: 66275 RVA: 0x0025D100 File Offset: 0x0025B300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OtherJoinSceneNotify);
		}

		// Token: 0x060102E4 RID: 66276 RVA: 0x0025D10E File Offset: 0x0025B30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OtherJoinSceneNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060102E5 RID: 66277 RVA: 0x0025D144 File Offset: 0x0025B344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060102E6 RID: 66278 RVA: 0x0025D180 File Offset: 0x0025B380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060102E7 RID: 66279 RVA: 0x0025D18D File Offset: 0x0025B38D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060102E8 RID: 66280 RVA: 0x0025D196 File Offset: 0x0025B396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060102E9 RID: 66281 RVA: 0x0025D1C8 File Offset: 0x0025B3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060102EA RID: 66282 RVA: 0x0025D208 File Offset: 0x0025B408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OtherJoinSceneNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new ScenePlayerInformation();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060102EB RID: 66283 RVA: 0x0025D25C File Offset: 0x0025B45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060102EC RID: 66284 RVA: 0x0025D268 File Offset: 0x0025B468
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.playerInfo_ == null)
					{
						this.PlayerInfo = new ScenePlayerInformation();
					}
					input.ReadMessage(this.PlayerInfo);
				}
			}
		}

		// Token: 0x04006771 RID: 26481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006772 RID: 26482
		public const int PlayerInfoFieldNumber = 10;

		// Token: 0x04006773 RID: 26483
		private ScenePlayerInformation playerInfo_;
	}
}
