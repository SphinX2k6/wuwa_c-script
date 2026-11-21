using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000819 RID: 2073
	[NetMessage(EMessageId.InstTeleportToResetPointRequest)]
	public sealed class InstTeleportToResetPointRequest : IMessage<InstTeleportToResetPointRequest>, IMessage, IEquatable<InstTeleportToResetPointRequest>, IDeepCloneable<InstTeleportToResetPointRequest>, IBufferMessage
	{
		// Token: 0x0600B9CB RID: 47563 RVA: 0x001BB504 File Offset: 0x001B9704
		[NullableContext(1)]
		public static InstTeleportToResetPointRequest Create()
		{
			return new InstTeleportToResetPointRequest();
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x0600B9CC RID: 47564 RVA: 0x001BB50B File Offset: 0x001B970B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x0600B9CD RID: 47565 RVA: 0x001BB50E File Offset: 0x001B970E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstTeleportToResetPointRequest.Descriptor;
			}
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x001BB515 File Offset: 0x001B9715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointRequest()
		{
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x001BB51D File Offset: 0x001B971D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointRequest(InstTeleportToResetPointRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x001BB536 File Offset: 0x001B9736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstTeleportToResetPointRequest Clone()
		{
			return new InstTeleportToResetPointRequest(this);
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x001BB53E File Offset: 0x001B973E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstTeleportToResetPointRequest);
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x001BB54C File Offset: 0x001B974C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstTeleportToResetPointRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B9D3 RID: 47571 RVA: 0x001BB56C File Offset: 0x001B976C
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

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x001BB592 File Offset: 0x001B9792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x001BB59F File Offset: 0x001B979F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x001BB5A8 File Offset: 0x001B97A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9D7 RID: 47575 RVA: 0x001BB5C0 File Offset: 0x001B97C0
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

		// Token: 0x0600B9D8 RID: 47576 RVA: 0x001BB5E6 File Offset: 0x001B97E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstTeleportToResetPointRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B9D9 RID: 47577 RVA: 0x001BB603 File Offset: 0x001B9803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x001BB60C File Offset: 0x001B980C
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

		// Token: 0x04005230 RID: 21040
		private UnknownFieldSet _unknownFields;
	}
}
