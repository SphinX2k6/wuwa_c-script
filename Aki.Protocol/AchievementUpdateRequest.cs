using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000067 RID: 103
	[NetMessage(EMessageId.AchievementUpdateRequest)]
	public sealed class AchievementUpdateRequest : IMessage<AchievementUpdateRequest>, IMessage, IEquatable<AchievementUpdateRequest>, IDeepCloneable<AchievementUpdateRequest>, IBufferMessage
	{
		// Token: 0x0600169E RID: 5790 RVA: 0x0003B5A2 File Offset: 0x000397A2
		[NullableContext(1)]
		public static AchievementUpdateRequest Create()
		{
			return new AchievementUpdateRequest();
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x0003B5A9 File Offset: 0x000397A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0003B5AC File Offset: 0x000397AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementUpdateRequest.Descriptor;
			}
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0003B5B3 File Offset: 0x000397B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateRequest()
		{
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0003B5BB File Offset: 0x000397BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateRequest(AchievementUpdateRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0003B5D4 File Offset: 0x000397D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementUpdateRequest Clone()
		{
			return new AchievementUpdateRequest(this);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0003B5DC File Offset: 0x000397DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementUpdateRequest);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0003B5EA File Offset: 0x000397EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementUpdateRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0003B608 File Offset: 0x00039808
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

		// Token: 0x060016A7 RID: 5799 RVA: 0x0003B62E File Offset: 0x0003982E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0003B63B File Offset: 0x0003983B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0003B644 File Offset: 0x00039844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0003B65C File Offset: 0x0003985C
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

		// Token: 0x060016AB RID: 5803 RVA: 0x0003B682 File Offset: 0x00039882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x0003B69F File Offset: 0x0003989F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0003B6A8 File Offset: 0x000398A8
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

		// Token: 0x040020EF RID: 8431
		private UnknownFieldSet _unknownFields;
	}
}
