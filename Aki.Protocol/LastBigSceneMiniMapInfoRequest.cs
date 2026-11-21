using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D5 RID: 2261
	[NetMessage(EMessageId.LastBigSceneMiniMapInfoRequest)]
	public sealed class LastBigSceneMiniMapInfoRequest : IMessage<LastBigSceneMiniMapInfoRequest>, IMessage, IEquatable<LastBigSceneMiniMapInfoRequest>, IDeepCloneable<LastBigSceneMiniMapInfoRequest>, IBufferMessage
	{
		// Token: 0x0600C86E RID: 51310 RVA: 0x001DA268 File Offset: 0x001D8468
		[NullableContext(1)]
		public static LastBigSceneMiniMapInfoRequest Create()
		{
			return new LastBigSceneMiniMapInfoRequest();
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x0600C86F RID: 51311 RVA: 0x001DA26F File Offset: 0x001D846F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x0600C870 RID: 51312 RVA: 0x001DA272 File Offset: 0x001D8472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LastBigSceneMiniMapInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x001DA279 File Offset: 0x001D8479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoRequest()
		{
		}

		// Token: 0x0600C872 RID: 51314 RVA: 0x001DA281 File Offset: 0x001D8481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoRequest(LastBigSceneMiniMapInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C873 RID: 51315 RVA: 0x001DA29A File Offset: 0x001D849A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoRequest Clone()
		{
			return new LastBigSceneMiniMapInfoRequest(this);
		}

		// Token: 0x0600C874 RID: 51316 RVA: 0x001DA2A2 File Offset: 0x001D84A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LastBigSceneMiniMapInfoRequest);
		}

		// Token: 0x0600C875 RID: 51317 RVA: 0x001DA2B0 File Offset: 0x001D84B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LastBigSceneMiniMapInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x001DA2D0 File Offset: 0x001D84D0
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

		// Token: 0x0600C877 RID: 51319 RVA: 0x001DA2F6 File Offset: 0x001D84F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C878 RID: 51320 RVA: 0x001DA303 File Offset: 0x001D8503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C879 RID: 51321 RVA: 0x001DA30C File Offset: 0x001D850C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C87A RID: 51322 RVA: 0x001DA324 File Offset: 0x001D8524
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

		// Token: 0x0600C87B RID: 51323 RVA: 0x001DA34A File Offset: 0x001D854A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LastBigSceneMiniMapInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C87C RID: 51324 RVA: 0x001DA367 File Offset: 0x001D8567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C87D RID: 51325 RVA: 0x001DA370 File Offset: 0x001D8570
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

		// Token: 0x040055FB RID: 22011
		private UnknownFieldSet _unknownFields;
	}
}
