using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000539 RID: 1337
	[NetMessage(EMessageId.FightDataCheckNotify)]
	public sealed class FightDataCheckNotify : IMessage<FightDataCheckNotify>, IMessage, IEquatable<FightDataCheckNotify>, IDeepCloneable<FightDataCheckNotify>, IBufferMessage
	{
		// Token: 0x06007D41 RID: 32065 RVA: 0x0012F842 File Offset: 0x0012DA42
		[NullableContext(1)]
		public static FightDataCheckNotify Create()
		{
			return new FightDataCheckNotify();
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06007D42 RID: 32066 RVA: 0x0012F849 File Offset: 0x0012DA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06007D43 RID: 32067 RVA: 0x0012F84C File Offset: 0x0012DA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightDataCheckNotify.Descriptor;
			}
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x0012F853 File Offset: 0x0012DA53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightDataCheckNotify()
		{
		}

		// Token: 0x06007D45 RID: 32069 RVA: 0x0012F85B File Offset: 0x0012DA5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightDataCheckNotify(FightDataCheckNotify other) : this()
		{
			this.result_ = other.result_;
			this.changeList_ = other.changeList_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D46 RID: 32070 RVA: 0x0012F88C File Offset: 0x0012DA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightDataCheckNotify Clone()
		{
			return new FightDataCheckNotify(this);
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06007D47 RID: 32071 RVA: 0x0012F894 File Offset: 0x0012DA94
		// (set) Token: 0x06007D48 RID: 32072 RVA: 0x0012F89C File Offset: 0x0012DA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06007D49 RID: 32073 RVA: 0x0012F8A5 File Offset: 0x0012DAA5
		// (set) Token: 0x06007D4A RID: 32074 RVA: 0x0012F8AD File Offset: 0x0012DAAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChangeList
		{
			get
			{
				return this.changeList_;
			}
			set
			{
				this.changeList_ = value;
			}
		}

		// Token: 0x06007D4B RID: 32075 RVA: 0x0012F8B6 File Offset: 0x0012DAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightDataCheckNotify);
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x0012F8C4 File Offset: 0x0012DAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightDataCheckNotify other)
		{
			return other != null && (other == this || (this.Result == other.Result && this.ChangeList == other.ChangeList && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x0012F904 File Offset: 0x0012DB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Result)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this.ChangeList != 0)
			{
				num ^= this.ChangeList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D4E RID: 32078 RVA: 0x0012F95C File Offset: 0x0012DB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D4F RID: 32079 RVA: 0x0012F969 File Offset: 0x0012DB69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D50 RID: 32080 RVA: 0x0012F974 File Offset: 0x0012DB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Result);
			}
			if (this.ChangeList != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ChangeList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D51 RID: 32081 RVA: 0x0012F9D0 File Offset: 0x0012DBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Result)
			{
				num += 2;
			}
			if (this.ChangeList != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChangeList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x0012FA1C File Offset: 0x0012DC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightDataCheckNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Result)
			{
				this.Result = other.Result;
			}
			if (other.ChangeList != 0)
			{
				this.ChangeList = other.ChangeList;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x0012FA6C File Offset: 0x0012DC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D54 RID: 32084 RVA: 0x0012FA78 File Offset: 0x0012DC78
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
				if (num != 40U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChangeList = input.ReadInt32();
					}
				}
				else
				{
					this.Result = input.ReadBool();
				}
			}
		}

		// Token: 0x04003FC0 RID: 16320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FC1 RID: 16321
		public const int ResultFieldNumber = 5;

		// Token: 0x04003FC2 RID: 16322
		private bool result_;

		// Token: 0x04003FC3 RID: 16323
		public const int ChangeListFieldNumber = 7;

		// Token: 0x04003FC4 RID: 16324
		private int changeList_;
	}
}
