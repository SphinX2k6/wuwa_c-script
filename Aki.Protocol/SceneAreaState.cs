using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200117B RID: 4475
	public sealed class SceneAreaState : IMessage<SceneAreaState>, IMessage, IEquatable<SceneAreaState>, IDeepCloneable<SceneAreaState>, IBufferMessage
	{
		// Token: 0x06017E77 RID: 97911 RVA: 0x0037AA7F File Offset: 0x00378C7F
		[NullableContext(1)]
		public static SceneAreaState Create()
		{
			return new SceneAreaState();
		}

		// Token: 0x17005076 RID: 20598
		// (get) Token: 0x06017E78 RID: 97912 RVA: 0x0037AA86 File Offset: 0x00378C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneAreaState> Parser
		{
			get
			{
				return SceneAreaState._parser;
			}
		}

		// Token: 0x17005077 RID: 20599
		// (get) Token: 0x06017E79 RID: 97913 RVA: 0x0037AA8D File Offset: 0x00378C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005078 RID: 20600
		// (get) Token: 0x06017E7A RID: 97914 RVA: 0x0037AA90 File Offset: 0x00378C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneAreaState.Descriptor;
			}
		}

		// Token: 0x06017E7B RID: 97915 RVA: 0x0037AA97 File Offset: 0x00378C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaState()
		{
		}

		// Token: 0x06017E7C RID: 97916 RVA: 0x0037AA9F File Offset: 0x00378C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaState(SceneAreaState other) : this()
		{
			this.areaId_ = other.areaId_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017E7D RID: 97917 RVA: 0x0037AAD0 File Offset: 0x00378CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneAreaState Clone()
		{
			return new SceneAreaState(this);
		}

		// Token: 0x17005079 RID: 20601
		// (get) Token: 0x06017E7E RID: 97918 RVA: 0x0037AAD8 File Offset: 0x00378CD8
		// (set) Token: 0x06017E7F RID: 97919 RVA: 0x0037AAE0 File Offset: 0x00378CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x1700507A RID: 20602
		// (get) Token: 0x06017E80 RID: 97920 RVA: 0x0037AAE9 File Offset: 0x00378CE9
		// (set) Token: 0x06017E81 RID: 97921 RVA: 0x0037AAF1 File Offset: 0x00378CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06017E82 RID: 97922 RVA: 0x0037AAFA File Offset: 0x00378CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneAreaState);
		}

		// Token: 0x06017E83 RID: 97923 RVA: 0x0037AB08 File Offset: 0x00378D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneAreaState other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017E84 RID: 97924 RVA: 0x0037AB48 File Offset: 0x00378D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.State)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017E85 RID: 97925 RVA: 0x0037ABA0 File Offset: 0x00378DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017E86 RID: 97926 RVA: 0x0037ABAD File Offset: 0x00378DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017E87 RID: 97927 RVA: 0x0037ABB8 File Offset: 0x00378DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.AreaId);
			}
			if (this.State)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017E88 RID: 97928 RVA: 0x0037AC10 File Offset: 0x00378E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AreaId);
			}
			if (this.State)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017E89 RID: 97929 RVA: 0x0037AC5C File Offset: 0x00378E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneAreaState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0)
			{
				this.AreaId = other.AreaId;
			}
			if (other.State)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017E8A RID: 97930 RVA: 0x0037ACAC File Offset: 0x00378EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017E8B RID: 97931 RVA: 0x0037ACB8 File Offset: 0x00378EB8
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.State = input.ReadBool();
					}
				}
				else
				{
					this.AreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E75 RID: 36469
		private static readonly MessageParser<SceneAreaState> _parser = new MessageParser<SceneAreaState>(() => new SceneAreaState());

		// Token: 0x04008E76 RID: 36470
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E77 RID: 36471
		public const int AreaIdFieldNumber = 1;

		// Token: 0x04008E78 RID: 36472
		private int areaId_;

		// Token: 0x04008E79 RID: 36473
		public const int StateFieldNumber = 2;

		// Token: 0x04008E7A RID: 36474
		private bool state_;
	}
}
