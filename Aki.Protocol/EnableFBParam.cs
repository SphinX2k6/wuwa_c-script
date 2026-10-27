using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000433 RID: 1075
	public sealed class EnableFBParam : IMessage<EnableFBParam>, IMessage, IEquatable<EnableFBParam>, IDeepCloneable<EnableFBParam>, IBufferMessage
	{
		// Token: 0x06006713 RID: 26387 RVA: 0x000F7AF5 File Offset: 0x000F5CF5
		[NullableContext(1)]
		public static EnableFBParam Create()
		{
			return new EnableFBParam();
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06006714 RID: 26388 RVA: 0x000F7AFC File Offset: 0x000F5CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06006715 RID: 26389 RVA: 0x000F7AFF File Offset: 0x000F5CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableFBParam.Descriptor;
			}
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x000F7B06 File Offset: 0x000F5D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFBParam()
		{
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x000F7B19 File Offset: 0x000F5D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFBParam(EnableFBParam other) : this()
		{
			this.paramIntList_ = other.paramIntList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x000F7B43 File Offset: 0x000F5D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableFBParam Clone()
		{
			return new EnableFBParam(this);
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06006719 RID: 26393 RVA: 0x000F7B4B File Offset: 0x000F5D4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ParamIntList
		{
			get
			{
				return this.paramIntList_;
			}
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x000F7B53 File Offset: 0x000F5D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableFBParam);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x000F7B61 File Offset: 0x000F5D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableFBParam other)
		{
			return other != null && (other == this || (this.paramIntList_.Equals(other.paramIntList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600671C RID: 26396 RVA: 0x000F7B94 File Offset: 0x000F5D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.paramIntList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600671D RID: 26397 RVA: 0x000F7BC8 File Offset: 0x000F5DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600671E RID: 26398 RVA: 0x000F7BD5 File Offset: 0x000F5DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600671F RID: 26399 RVA: 0x000F7BDE File Offset: 0x000F5DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.paramIntList_.WriteTo(ref output, EnableFBParam._repeated_paramIntList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x000F7C08 File Offset: 0x000F5E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.paramIntList_.CalculateSize(EnableFBParam._repeated_paramIntList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x000F7C41 File Offset: 0x000F5E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableFBParam other)
		{
			if (other == null)
			{
				return;
			}
			this.paramIntList_.Add(other.paramIntList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x000F7C6F File Offset: 0x000F5E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x000F7C78 File Offset: 0x000F5E78
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.paramIntList_.AddEntriesFrom(ref input, EnableFBParam._repeated_paramIntList_codec);
				}
			}
		}

		// Token: 0x0400394C RID: 14668
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400394D RID: 14669
		public const int ParamIntListFieldNumber = 1;

		// Token: 0x0400394E RID: 14670
		private static readonly FieldCodec<int> _repeated_paramIntList_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400394F RID: 14671
		private readonly RepeatedField<int> paramIntList_ = new RepeatedField<int>();
	}
}
