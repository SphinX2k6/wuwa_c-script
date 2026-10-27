using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C49 RID: 3145
	[NetMessage(EMessageId.PhantomBattleCardGroupDeleteRequest)]
	public sealed class PhantomBattleCardGroupDeleteRequest : IMessage<PhantomBattleCardGroupDeleteRequest>, IMessage, IEquatable<PhantomBattleCardGroupDeleteRequest>, IDeepCloneable<PhantomBattleCardGroupDeleteRequest>, IBufferMessage
	{
		// Token: 0x060110E9 RID: 69865 RVA: 0x0027F7F3 File Offset: 0x0027D9F3
		[NullableContext(1)]
		public static PhantomBattleCardGroupDeleteRequest Create()
		{
			return new PhantomBattleCardGroupDeleteRequest();
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x060110EA RID: 69866 RVA: 0x0027F7FA File Offset: 0x0027D9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x060110EB RID: 69867 RVA: 0x0027F7FD File Offset: 0x0027D9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupDeleteRequest.Descriptor;
			}
		}

		// Token: 0x060110EC RID: 69868 RVA: 0x0027F804 File Offset: 0x0027DA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteRequest()
		{
		}

		// Token: 0x060110ED RID: 69869 RVA: 0x0027F80C File Offset: 0x0027DA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteRequest(PhantomBattleCardGroupDeleteRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060110EE RID: 69870 RVA: 0x0027F83D File Offset: 0x0027DA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupDeleteRequest Clone()
		{
			return new PhantomBattleCardGroupDeleteRequest(this);
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x060110EF RID: 69871 RVA: 0x0027F845 File Offset: 0x0027DA45
		// (set) Token: 0x060110F0 RID: 69872 RVA: 0x0027F84D File Offset: 0x0027DA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x060110F1 RID: 69873 RVA: 0x0027F856 File Offset: 0x0027DA56
		// (set) Token: 0x060110F2 RID: 69874 RVA: 0x0027F85E File Offset: 0x0027DA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x060110F3 RID: 69875 RVA: 0x0027F867 File Offset: 0x0027DA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupDeleteRequest);
		}

		// Token: 0x060110F4 RID: 69876 RVA: 0x0027F875 File Offset: 0x0027DA75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupDeleteRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060110F5 RID: 69877 RVA: 0x0027F8B4 File Offset: 0x0027DAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060110F6 RID: 69878 RVA: 0x0027F90C File Offset: 0x0027DB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060110F7 RID: 69879 RVA: 0x0027F919 File Offset: 0x0027DB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060110F8 RID: 69880 RVA: 0x0027F924 File Offset: 0x0027DB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Index);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060110F9 RID: 69881 RVA: 0x0027F980 File Offset: 0x0027DB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060110FA RID: 69882 RVA: 0x0027F9D8 File Offset: 0x0027DBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupDeleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060110FB RID: 69883 RVA: 0x0027FA28 File Offset: 0x0027DC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060110FC RID: 69884 RVA: 0x0027FA34 File Offset: 0x0027DC34
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
				if (num != 80U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C18 RID: 27672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C19 RID: 27673
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x04006C1A RID: 27674
		private int activityId_;

		// Token: 0x04006C1B RID: 27675
		public const int IndexFieldNumber = 10;

		// Token: 0x04006C1C RID: 27676
		private int index_;
	}
}
