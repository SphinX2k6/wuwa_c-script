using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000179 RID: 377
	[NetMessage(EMessageId.BattlePassTaskRequest)]
	public sealed class BattlePassTaskRequest : IMessage<BattlePassTaskRequest>, IMessage, IEquatable<BattlePassTaskRequest>, IDeepCloneable<BattlePassTaskRequest>, IBufferMessage
	{
		// Token: 0x06002E38 RID: 11832 RVA: 0x0007775D File Offset: 0x0007595D
		[NullableContext(1)]
		public static BattlePassTaskRequest Create()
		{
			return new BattlePassTaskRequest();
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x00077764 File Offset: 0x00075964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x00077767 File Offset: 0x00075967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskRequest.Descriptor;
			}
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x0007776E File Offset: 0x0007596E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskRequest()
		{
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00077776 File Offset: 0x00075976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskRequest(BattlePassTaskRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x0007778F File Offset: 0x0007598F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskRequest Clone()
		{
			return new BattlePassTaskRequest(this);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x00077797 File Offset: 0x00075997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskRequest);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000777A5 File Offset: 0x000759A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000777C4 File Offset: 0x000759C4
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

		// Token: 0x06002E41 RID: 11841 RVA: 0x000777EA File Offset: 0x000759EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x000777F7 File Offset: 0x000759F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00077800 File Offset: 0x00075A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x00077818 File Offset: 0x00075A18
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

		// Token: 0x06002E45 RID: 11845 RVA: 0x0007783E File Offset: 0x00075A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x0007785B File Offset: 0x00075A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x00077864 File Offset: 0x00075A64
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

		// Token: 0x040028BC RID: 10428
		private UnknownFieldSet _unknownFields;
	}
}
