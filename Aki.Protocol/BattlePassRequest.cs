using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000173 RID: 371
	[NetMessage(EMessageId.BattlePassRequest)]
	public sealed class BattlePassRequest : IMessage<BattlePassRequest>, IMessage, IEquatable<BattlePassRequest>, IDeepCloneable<BattlePassRequest>, IBufferMessage
	{
		// Token: 0x06002DC7 RID: 11719 RVA: 0x00076965 File Offset: 0x00074B65
		[NullableContext(1)]
		public static BattlePassRequest Create()
		{
			return new BattlePassRequest();
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x0007696C File Offset: 0x00074B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x0007696F File Offset: 0x00074B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassRequest.Descriptor;
			}
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00076976 File Offset: 0x00074B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRequest()
		{
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x0007697E File Offset: 0x00074B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRequest(BattlePassRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00076997 File Offset: 0x00074B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRequest Clone()
		{
			return new BattlePassRequest(this);
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x0007699F File Offset: 0x00074B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassRequest);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x000769AD File Offset: 0x00074BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x000769CC File Offset: 0x00074BCC
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

		// Token: 0x06002DD0 RID: 11728 RVA: 0x000769F2 File Offset: 0x00074BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x000769FF File Offset: 0x00074BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00076A08 File Offset: 0x00074C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00076A20 File Offset: 0x00074C20
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

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00076A46 File Offset: 0x00074C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00076A63 File Offset: 0x00074C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00076A6C File Offset: 0x00074C6C
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

		// Token: 0x040028A2 RID: 10402
		private UnknownFieldSet _unknownFields;
	}
}
