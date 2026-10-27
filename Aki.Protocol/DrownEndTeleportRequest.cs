using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000413 RID: 1043
	[NetMessage(EMessageId.DrownEndTeleportRequest)]
	public sealed class DrownEndTeleportRequest : IMessage<DrownEndTeleportRequest>, IMessage, IEquatable<DrownEndTeleportRequest>, IDeepCloneable<DrownEndTeleportRequest>, IBufferMessage
	{
		// Token: 0x06006468 RID: 25704 RVA: 0x000F1274 File Offset: 0x000EF474
		[NullableContext(1)]
		public static DrownEndTeleportRequest Create()
		{
			return new DrownEndTeleportRequest();
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06006469 RID: 25705 RVA: 0x000F127B File Offset: 0x000EF47B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x0600646A RID: 25706 RVA: 0x000F127E File Offset: 0x000EF47E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownEndTeleportRequest.Descriptor;
			}
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x000F1285 File Offset: 0x000EF485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportRequest()
		{
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x000F128D File Offset: 0x000EF48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportRequest(DrownEndTeleportRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600646D RID: 25709 RVA: 0x000F12A6 File Offset: 0x000EF4A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportRequest Clone()
		{
			return new DrownEndTeleportRequest(this);
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x000F12AE File Offset: 0x000EF4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownEndTeleportRequest);
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x000F12BC File Offset: 0x000EF4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownEndTeleportRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x000F12DC File Offset: 0x000EF4DC
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

		// Token: 0x06006471 RID: 25713 RVA: 0x000F1302 File Offset: 0x000EF502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x000F130F File Offset: 0x000EF50F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006473 RID: 25715 RVA: 0x000F1318 File Offset: 0x000EF518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006474 RID: 25716 RVA: 0x000F1330 File Offset: 0x000EF530
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

		// Token: 0x06006475 RID: 25717 RVA: 0x000F1356 File Offset: 0x000EF556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownEndTeleportRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006476 RID: 25718 RVA: 0x000F1373 File Offset: 0x000EF573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x000F137C File Offset: 0x000EF57C
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

		// Token: 0x04003866 RID: 14438
		private UnknownFieldSet _unknownFields;
	}
}
