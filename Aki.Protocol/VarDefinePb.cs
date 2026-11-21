using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200153C RID: 5436
	public sealed class VarDefinePb : IMessage<VarDefinePb>, IMessage, IEquatable<VarDefinePb>, IDeepCloneable<VarDefinePb>, IBufferMessage
	{
		// Token: 0x0601CCAA RID: 117930 RVA: 0x0042C0A0 File Offset: 0x0042A2A0
		[NullableContext(1)]
		public static VarDefinePb Create()
		{
			return new VarDefinePb();
		}

		// Token: 0x17006163 RID: 24931
		// (get) Token: 0x0601CCAB RID: 117931 RVA: 0x0042C0A7 File Offset: 0x0042A2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<VarDefinePb> Parser
		{
			get
			{
				return VarDefinePb._parser;
			}
		}

		// Token: 0x17006164 RID: 24932
		// (get) Token: 0x0601CCAC RID: 117932 RVA: 0x0042C0AE File Offset: 0x0042A2AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006165 RID: 24933
		// (get) Token: 0x0601CCAD RID: 117933 RVA: 0x0042C0B1 File Offset: 0x0042A2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VarDefinePb.Descriptor;
			}
		}

		// Token: 0x0601CCAE RID: 117934 RVA: 0x0042C0B8 File Offset: 0x0042A2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb()
		{
		}

		// Token: 0x0601CCAF RID: 117935 RVA: 0x0042C0C0 File Offset: 0x0042A2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb(VarDefinePb other) : this()
		{
			this.varType_ = other.varType_;
			switch (other.ValueCase)
			{
			case VarDefinePb.ValueOneofCase.Boolean:
				this.Boolean = other.Boolean;
				break;
			case VarDefinePb.ValueOneofCase.Int:
				this.Int = other.Int;
				break;
			case VarDefinePb.ValueOneofCase.String:
				this.String = other.String;
				break;
			case VarDefinePb.ValueOneofCase.Float:
				this.Float = other.Float;
				break;
			case VarDefinePb.ValueOneofCase.Entity:
				this.Entity = other.Entity;
				break;
			case VarDefinePb.ValueOneofCase.Quest:
				this.Quest = other.Quest;
				break;
			case VarDefinePb.ValueOneofCase.QuestState:
				this.QuestState = other.QuestState;
				break;
			case VarDefinePb.ValueOneofCase.Transform:
				this.Transform = other.Transform.Clone();
				break;
			case VarDefinePb.ValueOneofCase.Prefab:
				this.Prefab = other.Prefab;
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CCB0 RID: 117936 RVA: 0x0042C1A9 File Offset: 0x0042A3A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb Clone()
		{
			return new VarDefinePb(this);
		}

		// Token: 0x17006166 RID: 24934
		// (get) Token: 0x0601CCB1 RID: 117937 RVA: 0x0042C1B1 File Offset: 0x0042A3B1
		// (set) Token: 0x0601CCB2 RID: 117938 RVA: 0x0042C1B9 File Offset: 0x0042A3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int VarType
		{
			get
			{
				return this.varType_;
			}
			set
			{
				this.varType_ = value;
			}
		}

		// Token: 0x17006167 RID: 24935
		// (get) Token: 0x0601CCB3 RID: 117939 RVA: 0x0042C1C2 File Offset: 0x0042A3C2
		// (set) Token: 0x0601CCB4 RID: 117940 RVA: 0x0042C1D9 File Offset: 0x0042A3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Boolean
		{
			get
			{
				return this.HasBoolean && (bool)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Boolean;
			}
		}

		// Token: 0x17006168 RID: 24936
		// (get) Token: 0x0601CCB5 RID: 117941 RVA: 0x0042C1EE File Offset: 0x0042A3EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasBoolean
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Boolean;
			}
		}

		// Token: 0x0601CCB6 RID: 117942 RVA: 0x0042C1F9 File Offset: 0x0042A3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearBoolean()
		{
			if (this.HasBoolean)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17006169 RID: 24937
		// (get) Token: 0x0601CCB7 RID: 117943 RVA: 0x0042C209 File Offset: 0x0042A409
		// (set) Token: 0x0601CCB8 RID: 117944 RVA: 0x0042C221 File Offset: 0x0042A421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Int
		{
			get
			{
				if (!this.HasInt)
				{
					return 0L;
				}
				return (long)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Int;
			}
		}

		// Token: 0x1700616A RID: 24938
		// (get) Token: 0x0601CCB9 RID: 117945 RVA: 0x0042C236 File Offset: 0x0042A436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasInt
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Int;
			}
		}

		// Token: 0x0601CCBA RID: 117946 RVA: 0x0042C241 File Offset: 0x0042A441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearInt()
		{
			if (this.HasInt)
			{
				this.ClearValue();
			}
		}

		// Token: 0x1700616B RID: 24939
		// (get) Token: 0x0601CCBB RID: 117947 RVA: 0x0042C251 File Offset: 0x0042A451
		// (set) Token: 0x0601CCBC RID: 117948 RVA: 0x0042C26C File Offset: 0x0042A46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string String
		{
			get
			{
				if (!this.HasString)
				{
					return "";
				}
				return (string)this.value_;
			}
			set
			{
				this.value_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.valueCase_ = VarDefinePb.ValueOneofCase.String;
			}
		}

		// Token: 0x1700616C RID: 24940
		// (get) Token: 0x0601CCBD RID: 117949 RVA: 0x0042C286 File Offset: 0x0042A486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasString
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.String;
			}
		}

		// Token: 0x0601CCBE RID: 117950 RVA: 0x0042C291 File Offset: 0x0042A491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearString()
		{
			if (this.HasString)
			{
				this.ClearValue();
			}
		}

		// Token: 0x1700616D RID: 24941
		// (get) Token: 0x0601CCBF RID: 117951 RVA: 0x0042C2A1 File Offset: 0x0042A4A1
		// (set) Token: 0x0601CCC0 RID: 117952 RVA: 0x0042C2BC File Offset: 0x0042A4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Float
		{
			get
			{
				if (!this.HasFloat)
				{
					return 0f;
				}
				return (float)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Float;
			}
		}

		// Token: 0x1700616E RID: 24942
		// (get) Token: 0x0601CCC1 RID: 117953 RVA: 0x0042C2D1 File Offset: 0x0042A4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFloat
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Float;
			}
		}

		// Token: 0x0601CCC2 RID: 117954 RVA: 0x0042C2DC File Offset: 0x0042A4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFloat()
		{
			if (this.HasFloat)
			{
				this.ClearValue();
			}
		}

		// Token: 0x1700616F RID: 24943
		// (get) Token: 0x0601CCC3 RID: 117955 RVA: 0x0042C2EC File Offset: 0x0042A4EC
		// (set) Token: 0x0601CCC4 RID: 117956 RVA: 0x0042C303 File Offset: 0x0042A503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Entity
		{
			get
			{
				if (!this.HasEntity)
				{
					return 0;
				}
				return (int)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Entity;
			}
		}

		// Token: 0x17006170 RID: 24944
		// (get) Token: 0x0601CCC5 RID: 117957 RVA: 0x0042C318 File Offset: 0x0042A518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEntity
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Entity;
			}
		}

		// Token: 0x0601CCC6 RID: 117958 RVA: 0x0042C323 File Offset: 0x0042A523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEntity()
		{
			if (this.HasEntity)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17006171 RID: 24945
		// (get) Token: 0x0601CCC7 RID: 117959 RVA: 0x0042C333 File Offset: 0x0042A533
		// (set) Token: 0x0601CCC8 RID: 117960 RVA: 0x0042C34A File Offset: 0x0042A54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Quest
		{
			get
			{
				if (!this.HasQuest)
				{
					return 0;
				}
				return (int)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Quest;
			}
		}

		// Token: 0x17006172 RID: 24946
		// (get) Token: 0x0601CCC9 RID: 117961 RVA: 0x0042C35F File Offset: 0x0042A55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasQuest
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Quest;
			}
		}

		// Token: 0x0601CCCA RID: 117962 RVA: 0x0042C36A File Offset: 0x0042A56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearQuest()
		{
			if (this.HasQuest)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17006173 RID: 24947
		// (get) Token: 0x0601CCCB RID: 117963 RVA: 0x0042C37A File Offset: 0x0042A57A
		// (set) Token: 0x0601CCCC RID: 117964 RVA: 0x0042C391 File Offset: 0x0042A591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestState
		{
			get
			{
				if (!this.HasQuestState)
				{
					return 0;
				}
				return (int)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.QuestState;
			}
		}

		// Token: 0x17006174 RID: 24948
		// (get) Token: 0x0601CCCD RID: 117965 RVA: 0x0042C3A6 File Offset: 0x0042A5A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasQuestState
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.QuestState;
			}
		}

		// Token: 0x0601CCCE RID: 117966 RVA: 0x0042C3B1 File Offset: 0x0042A5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearQuestState()
		{
			if (this.HasQuestState)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17006175 RID: 24949
		// (get) Token: 0x0601CCCF RID: 117967 RVA: 0x0042C3C1 File Offset: 0x0042A5C1
		// (set) Token: 0x0601CCD0 RID: 117968 RVA: 0x0042C3DA File Offset: 0x0042A5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Transform Transform
		{
			get
			{
				if (this.valueCase_ != VarDefinePb.ValueOneofCase.Transform)
				{
					return null;
				}
				return (Transform)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = ((value == null) ? VarDefinePb.ValueOneofCase.None : VarDefinePb.ValueOneofCase.Transform);
			}
		}

		// Token: 0x17006176 RID: 24950
		// (get) Token: 0x0601CCD1 RID: 117969 RVA: 0x0042C3F1 File Offset: 0x0042A5F1
		// (set) Token: 0x0601CCD2 RID: 117970 RVA: 0x0042C409 File Offset: 0x0042A609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Prefab
		{
			get
			{
				if (!this.HasPrefab)
				{
					return 0L;
				}
				return (long)this.value_;
			}
			set
			{
				this.value_ = value;
				this.valueCase_ = VarDefinePb.ValueOneofCase.Prefab;
			}
		}

		// Token: 0x17006177 RID: 24951
		// (get) Token: 0x0601CCD3 RID: 117971 RVA: 0x0042C41F File Offset: 0x0042A61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPrefab
		{
			get
			{
				return this.valueCase_ == VarDefinePb.ValueOneofCase.Prefab;
			}
		}

		// Token: 0x0601CCD4 RID: 117972 RVA: 0x0042C42B File Offset: 0x0042A62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPrefab()
		{
			if (this.HasPrefab)
			{
				this.ClearValue();
			}
		}

		// Token: 0x17006178 RID: 24952
		// (get) Token: 0x0601CCD5 RID: 117973 RVA: 0x0042C43B File Offset: 0x0042A63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VarDefinePb.ValueOneofCase ValueCase
		{
			get
			{
				return this.valueCase_;
			}
		}

		// Token: 0x0601CCD6 RID: 117974 RVA: 0x0042C443 File Offset: 0x0042A643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearValue()
		{
			this.valueCase_ = VarDefinePb.ValueOneofCase.None;
			this.value_ = null;
		}

		// Token: 0x0601CCD7 RID: 117975 RVA: 0x0042C453 File Offset: 0x0042A653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VarDefinePb);
		}

		// Token: 0x0601CCD8 RID: 117976 RVA: 0x0042C464 File Offset: 0x0042A664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VarDefinePb other)
		{
			return other != null && (other == this || (this.VarType == other.VarType && this.Boolean == other.Boolean && this.Int == other.Int && !(this.String != other.String) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Float, other.Float) && this.Entity == other.Entity && this.Quest == other.Quest && this.QuestState == other.QuestState && object.Equals(this.Transform, other.Transform) && this.Prefab == other.Prefab && this.ValueCase == other.ValueCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CCD9 RID: 117977 RVA: 0x0042C554 File Offset: 0x0042A754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.VarType != 0)
			{
				num ^= this.VarType.GetHashCode();
			}
			if (this.HasBoolean)
			{
				num ^= this.Boolean.GetHashCode();
			}
			if (this.HasInt)
			{
				num ^= this.Int.GetHashCode();
			}
			if (this.HasString)
			{
				num ^= this.String.GetHashCode();
			}
			if (this.HasFloat)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Float);
			}
			if (this.HasEntity)
			{
				num ^= this.Entity.GetHashCode();
			}
			if (this.HasQuest)
			{
				num ^= this.Quest.GetHashCode();
			}
			if (this.HasQuestState)
			{
				num ^= this.QuestState.GetHashCode();
			}
			if (this.valueCase_ == VarDefinePb.ValueOneofCase.Transform)
			{
				num ^= this.Transform.GetHashCode();
			}
			if (this.HasPrefab)
			{
				num ^= this.Prefab.GetHashCode();
			}
			num ^= (int)this.valueCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CCDA RID: 117978 RVA: 0x0042C67B File Offset: 0x0042A87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CCDB RID: 117979 RVA: 0x0042C688 File Offset: 0x0042A888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CCDC RID: 117980 RVA: 0x0042C694 File Offset: 0x0042A894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.VarType != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.VarType);
			}
			if (this.HasBoolean)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Boolean);
			}
			if (this.HasInt)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Int);
			}
			if (this.HasString)
			{
				output.WriteRawTag(34);
				output.WriteString(this.String);
			}
			if (this.HasFloat)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.Float);
			}
			if (this.HasEntity)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Entity);
			}
			if (this.HasQuest)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Quest);
			}
			if (this.HasQuestState)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.QuestState);
			}
			if (this.valueCase_ == VarDefinePb.ValueOneofCase.Transform)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Transform);
			}
			if (this.HasPrefab)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Prefab);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CCDD RID: 117981 RVA: 0x0042C7D0 File Offset: 0x0042A9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.VarType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.VarType);
			}
			if (this.HasBoolean)
			{
				num += 2;
			}
			if (this.HasInt)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Int);
			}
			if (this.HasString)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.String);
			}
			if (this.HasFloat)
			{
				num += 5;
			}
			if (this.HasEntity)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Entity);
			}
			if (this.HasQuest)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Quest);
			}
			if (this.HasQuestState)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestState);
			}
			if (this.valueCase_ == VarDefinePb.ValueOneofCase.Transform)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Transform);
			}
			if (this.HasPrefab)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Prefab);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CCDE RID: 117982 RVA: 0x0042C8D0 File Offset: 0x0042AAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VarDefinePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.VarType != 0)
			{
				this.VarType = other.VarType;
			}
			switch (other.ValueCase)
			{
			case VarDefinePb.ValueOneofCase.Boolean:
				this.Boolean = other.Boolean;
				break;
			case VarDefinePb.ValueOneofCase.Int:
				this.Int = other.Int;
				break;
			case VarDefinePb.ValueOneofCase.String:
				this.String = other.String;
				break;
			case VarDefinePb.ValueOneofCase.Float:
				this.Float = other.Float;
				break;
			case VarDefinePb.ValueOneofCase.Entity:
				this.Entity = other.Entity;
				break;
			case VarDefinePb.ValueOneofCase.Quest:
				this.Quest = other.Quest;
				break;
			case VarDefinePb.ValueOneofCase.QuestState:
				this.QuestState = other.QuestState;
				break;
			case VarDefinePb.ValueOneofCase.Transform:
				if (this.Transform == null)
				{
					this.Transform = new Transform();
				}
				this.Transform.MergeFrom(other.Transform);
				break;
			case VarDefinePb.ValueOneofCase.Prefab:
				this.Prefab = other.Prefab;
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CCDF RID: 117983 RVA: 0x0042C9DB File Offset: 0x0042ABDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CCE0 RID: 117984 RVA: 0x0042C9E4 File Offset: 0x0042ABE4
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
				if (num <= 45U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.VarType = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.Boolean = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Int = input.ReadInt64();
							continue;
						}
						if (num == 34U)
						{
							this.String = input.ReadString();
							continue;
						}
						if (num == 45U)
						{
							this.Float = input.ReadFloat();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.Entity = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Quest = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.QuestState = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						Transform transform = new Transform();
						if (this.valueCase_ == VarDefinePb.ValueOneofCase.Transform)
						{
							transform.MergeFrom(this.Transform);
						}
						input.ReadMessage(transform);
						this.Transform = transform;
						continue;
					}
					if (num == 80U)
					{
						this.Prefab = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A5BC RID: 42428
		private static readonly MessageParser<VarDefinePb> _parser = new MessageParser<VarDefinePb>(() => new VarDefinePb());

		// Token: 0x0400A5BD RID: 42429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5BE RID: 42430
		public const int VarTypeFieldNumber = 1;

		// Token: 0x0400A5BF RID: 42431
		private int varType_;

		// Token: 0x0400A5C0 RID: 42432
		public const int BooleanFieldNumber = 2;

		// Token: 0x0400A5C1 RID: 42433
		public const int IntFieldNumber = 3;

		// Token: 0x0400A5C2 RID: 42434
		public const int StringFieldNumber = 4;

		// Token: 0x0400A5C3 RID: 42435
		public const int FloatFieldNumber = 5;

		// Token: 0x0400A5C4 RID: 42436
		public const int EntityFieldNumber = 6;

		// Token: 0x0400A5C5 RID: 42437
		public const int QuestFieldNumber = 7;

		// Token: 0x0400A5C6 RID: 42438
		public const int QuestStateFieldNumber = 8;

		// Token: 0x0400A5C7 RID: 42439
		public const int TransformFieldNumber = 9;

		// Token: 0x0400A5C8 RID: 42440
		public const int PrefabFieldNumber = 10;

		// Token: 0x0400A5C9 RID: 42441
		private object value_;

		// Token: 0x0400A5CA RID: 42442
		private VarDefinePb.ValueOneofCase valueCase_;

		// Token: 0x02001A8D RID: 6797
		public enum ValueOneofCase
		{
			// Token: 0x0400D033 RID: 53299
			None,
			// Token: 0x0400D034 RID: 53300
			Boolean = 2,
			// Token: 0x0400D035 RID: 53301
			Int,
			// Token: 0x0400D036 RID: 53302
			String,
			// Token: 0x0400D037 RID: 53303
			Float,
			// Token: 0x0400D038 RID: 53304
			Entity,
			// Token: 0x0400D039 RID: 53305
			Quest,
			// Token: 0x0400D03A RID: 53306
			QuestState,
			// Token: 0x0400D03B RID: 53307
			Transform,
			// Token: 0x0400D03C RID: 53308
			Prefab
		}
	}
}
