using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B0 RID: 1712
	[NetMessage(EMessageId.GameStatsShowRequest)]
	public sealed class GameStatsShowRequest : IMessage<GameStatsShowRequest>, IMessage, IEquatable<GameStatsShowRequest>, IDeepCloneable<GameStatsShowRequest>, IBufferMessage
	{
		// Token: 0x06009D06 RID: 40198 RVA: 0x0017E044 File Offset: 0x0017C244
		[NullableContext(1)]
		public static GameStatsShowRequest Create()
		{
			return new GameStatsShowRequest();
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06009D07 RID: 40199 RVA: 0x0017E04B File Offset: 0x0017C24B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06009D08 RID: 40200 RVA: 0x0017E04E File Offset: 0x0017C24E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameStatsShowRequest.Descriptor;
			}
		}

		// Token: 0x06009D09 RID: 40201 RVA: 0x0017E055 File Offset: 0x0017C255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowRequest()
		{
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x0017E05D File Offset: 0x0017C25D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowRequest(GameStatsShowRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D0B RID: 40203 RVA: 0x0017E076 File Offset: 0x0017C276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameStatsShowRequest Clone()
		{
			return new GameStatsShowRequest(this);
		}

		// Token: 0x06009D0C RID: 40204 RVA: 0x0017E07E File Offset: 0x0017C27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameStatsShowRequest);
		}

		// Token: 0x06009D0D RID: 40205 RVA: 0x0017E08C File Offset: 0x0017C28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameStatsShowRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009D0E RID: 40206 RVA: 0x0017E0AC File Offset: 0x0017C2AC
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

		// Token: 0x06009D0F RID: 40207 RVA: 0x0017E0D2 File Offset: 0x0017C2D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D10 RID: 40208 RVA: 0x0017E0DF File Offset: 0x0017C2DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D11 RID: 40209 RVA: 0x0017E0E8 File Offset: 0x0017C2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D12 RID: 40210 RVA: 0x0017E100 File Offset: 0x0017C300
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

		// Token: 0x06009D13 RID: 40211 RVA: 0x0017E126 File Offset: 0x0017C326
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

		// Token: 0x06009D14 RID: 40212 RVA: 0x0017E143 File Offset: 0x0017C343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x0017E14C File Offset: 0x0017C34C
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

		// Token: 0x040049E8 RID: 18920
		private UnknownFieldSet _unknownFields;
	}
}
