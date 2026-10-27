using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DF RID: 4831
	public sealed class SurvivorsRewardStepPbData : IMessage<SurvivorsRewardStepPbData>, IMessage, IEquatable<SurvivorsRewardStepPbData>, IDeepCloneable<SurvivorsRewardStepPbData>, IBufferMessage
	{
		// Token: 0x06019B2B RID: 105259 RVA: 0x003BC5DF File Offset: 0x003BA7DF
		[NullableContext(1)]
		public static SurvivorsRewardStepPbData Create()
		{
			return new SurvivorsRewardStepPbData();
		}

		// Token: 0x170056B2 RID: 22194
		// (get) Token: 0x06019B2C RID: 105260 RVA: 0x003BC5E6 File Offset: 0x003BA7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056B3 RID: 22195
		// (get) Token: 0x06019B2D RID: 105261 RVA: 0x003BC5E9 File Offset: 0x003BA7E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsRewardStepPbData.Descriptor;
			}
		}

		// Token: 0x06019B2E RID: 105262 RVA: 0x003BC5F0 File Offset: 0x003BA7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRewardStepPbData()
		{
		}

		// Token: 0x06019B2F RID: 105263 RVA: 0x003BC5F8 File Offset: 0x003BA7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRewardStepPbData(SurvivorsRewardStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019B30 RID: 105264 RVA: 0x003BC611 File Offset: 0x003BA811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsRewardStepPbData Clone()
		{
			return new SurvivorsRewardStepPbData(this);
		}

		// Token: 0x06019B31 RID: 105265 RVA: 0x003BC619 File Offset: 0x003BA819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsRewardStepPbData);
		}

		// Token: 0x06019B32 RID: 105266 RVA: 0x003BC627 File Offset: 0x003BA827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsRewardStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019B33 RID: 105267 RVA: 0x003BC648 File Offset: 0x003BA848
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

		// Token: 0x06019B34 RID: 105268 RVA: 0x003BC66E File Offset: 0x003BA86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019B35 RID: 105269 RVA: 0x003BC67B File Offset: 0x003BA87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019B36 RID: 105270 RVA: 0x003BC684 File Offset: 0x003BA884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019B37 RID: 105271 RVA: 0x003BC69C File Offset: 0x003BA89C
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

		// Token: 0x06019B38 RID: 105272 RVA: 0x003BC6C2 File Offset: 0x003BA8C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsRewardStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019B39 RID: 105273 RVA: 0x003BC6DF File Offset: 0x003BA8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019B3A RID: 105274 RVA: 0x003BC6E8 File Offset: 0x003BA8E8
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

		// Token: 0x04009699 RID: 38553
		private UnknownFieldSet _unknownFields;
	}
}
