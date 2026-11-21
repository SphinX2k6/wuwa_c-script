using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B29 RID: 2857
	[NetMessage(EMessageId.NewTowerMedalInfoRequest)]
	public sealed class NewTowerMedalInfoRequest : IMessage<NewTowerMedalInfoRequest>, IMessage, IEquatable<NewTowerMedalInfoRequest>, IDeepCloneable<NewTowerMedalInfoRequest>, IBufferMessage
	{
		// Token: 0x0600F852 RID: 63570 RVA: 0x00243E9E File Offset: 0x0024209E
		[NullableContext(1)]
		public static NewTowerMedalInfoRequest Create()
		{
			return new NewTowerMedalInfoRequest();
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600F853 RID: 63571 RVA: 0x00243EA5 File Offset: 0x002420A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600F854 RID: 63572 RVA: 0x00243EA8 File Offset: 0x002420A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerMedalInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600F855 RID: 63573 RVA: 0x00243EAF File Offset: 0x002420AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoRequest()
		{
		}

		// Token: 0x0600F856 RID: 63574 RVA: 0x00243EB7 File Offset: 0x002420B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoRequest(NewTowerMedalInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F857 RID: 63575 RVA: 0x00243ED0 File Offset: 0x002420D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerMedalInfoRequest Clone()
		{
			return new NewTowerMedalInfoRequest(this);
		}

		// Token: 0x0600F858 RID: 63576 RVA: 0x00243ED8 File Offset: 0x002420D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerMedalInfoRequest);
		}

		// Token: 0x0600F859 RID: 63577 RVA: 0x00243EE6 File Offset: 0x002420E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerMedalInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600F85A RID: 63578 RVA: 0x00243F04 File Offset: 0x00242104
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

		// Token: 0x0600F85B RID: 63579 RVA: 0x00243F2A File Offset: 0x0024212A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F85C RID: 63580 RVA: 0x00243F37 File Offset: 0x00242137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F85D RID: 63581 RVA: 0x00243F40 File Offset: 0x00242140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F85E RID: 63582 RVA: 0x00243F58 File Offset: 0x00242158
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

		// Token: 0x0600F85F RID: 63583 RVA: 0x00243F7E File Offset: 0x0024217E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerMedalInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F860 RID: 63584 RVA: 0x00243F9B File Offset: 0x0024219B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F861 RID: 63585 RVA: 0x00243FA4 File Offset: 0x002421A4
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

		// Token: 0x040063FB RID: 25595
		private UnknownFieldSet _unknownFields;
	}
}
