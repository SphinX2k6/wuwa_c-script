using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000862 RID: 2146
	public sealed class JinzhouFlyData : IMessage<JinzhouFlyData>, IMessage, IEquatable<JinzhouFlyData>, IDeepCloneable<JinzhouFlyData>, IBufferMessage
	{
		// Token: 0x0600BF41 RID: 48961 RVA: 0x001C65EB File Offset: 0x001C47EB
		[NullableContext(1)]
		public static JinzhouFlyData Create()
		{
			return new JinzhouFlyData();
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x0600BF42 RID: 48962 RVA: 0x001C65F2 File Offset: 0x001C47F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x0600BF43 RID: 48963 RVA: 0x001C65F5 File Offset: 0x001C47F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JinzhouFlyData.Descriptor;
			}
		}

		// Token: 0x0600BF44 RID: 48964 RVA: 0x001C65FC File Offset: 0x001C47FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JinzhouFlyData()
		{
		}

		// Token: 0x0600BF45 RID: 48965 RVA: 0x001C6604 File Offset: 0x001C4804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JinzhouFlyData(JinzhouFlyData other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF46 RID: 48966 RVA: 0x001C6629 File Offset: 0x001C4829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JinzhouFlyData Clone()
		{
			return new JinzhouFlyData(this);
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x001C6631 File Offset: 0x001C4831
		// (set) Token: 0x0600BF48 RID: 48968 RVA: 0x001C6639 File Offset: 0x001C4839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x0600BF49 RID: 48969 RVA: 0x001C6642 File Offset: 0x001C4842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JinzhouFlyData);
		}

		// Token: 0x0600BF4A RID: 48970 RVA: 0x001C6650 File Offset: 0x001C4850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JinzhouFlyData other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF4B RID: 48971 RVA: 0x001C6680 File Offset: 0x001C4880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF4C RID: 48972 RVA: 0x001C66BF File Offset: 0x001C48BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF4D RID: 48973 RVA: 0x001C66CC File Offset: 0x001C48CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF4E RID: 48974 RVA: 0x001C66D5 File Offset: 0x001C48D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF4F RID: 48975 RVA: 0x001C6708 File Offset: 0x001C4908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x001C6746 File Offset: 0x001C4946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JinzhouFlyData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x001C6777 File Offset: 0x001C4977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF52 RID: 48978 RVA: 0x001C6780 File Offset: 0x001C4980
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400534C RID: 21324
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400534D RID: 21325
		public const int QuestIdFieldNumber = 1;

		// Token: 0x0400534E RID: 21326
		private int questId_;
	}
}
