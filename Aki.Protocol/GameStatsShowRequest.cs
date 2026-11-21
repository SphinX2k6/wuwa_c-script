using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069C RID: 1692
	[NetMessage(EMessageId.GameStatsShowRequest)]
	public sealed class GameStatsShowRequest : IMessage<GameStatsShowRequest>, IMessage, IEquatable<GameStatsShowRequest>, IDeepCloneable<GameStatsShowRequest>, IBufferMessage
	{
		// Token: 0x06009BB0 RID: 39856 RVA: 0x0017B615 File Offset: 0x00179815
		[NullableContext(1)]
		public static GameStatsShowRequest Create()
		{
			return new GameStatsShowRequest();
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06009BB1 RID: 39857 RVA: 0x0017B61C File Offset: 0x0017981C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06009BB2 RID: 39858 RVA: 0x0017B61F File Offset: 0x0017981F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameStatsShowRequest.Descriptor;
			}
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x0017B626 File Offset: 0x00179826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowRequest()
		{
		}

		// Token: 0x06009BB4 RID: 39860 RVA: 0x0017B62E File Offset: 0x0017982E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowRequest(GameStatsShowRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x0017B647 File Offset: 0x00179847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowRequest Clone()
		{
			return new GameStatsShowRequest(this);
		}

		// Token: 0x06009BB6 RID: 39862 RVA: 0x0017B64F File Offset: 0x0017984F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameStatsShowRequest);
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x0017B65D File Offset: 0x0017985D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameStatsShowRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009BB8 RID: 39864 RVA: 0x0017B67C File Offset: 0x0017987C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BB9 RID: 39865 RVA: 0x0017B6A2 File Offset: 0x001798A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x0017B6AF File Offset: 0x001798AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BBB RID: 39867 RVA: 0x0017B6B8 File Offset: 0x001798B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BBC RID: 39868 RVA: 0x0017B6D0 File Offset: 0x001798D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BBD RID: 39869 RVA: 0x0017B6F6 File Offset: 0x001798F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameStatsShowRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009BBE RID: 39870 RVA: 0x0017B713 File Offset: 0x00179913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BBF RID: 39871 RVA: 0x0017B71C File Offset: 0x0017991C
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040049E1 RID: 18913
		private UnknownFieldSet _unknownFields;
	}
}
